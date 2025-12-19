using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RideShareApp.Backend
{
    public class Backend 
    {
        private readonly string userFile = Path.Combine(Application.StartupPath, "users.txt");
        private readonly string tripFile = Path.Combine(Application.StartupPath, "trips.txt");
        private readonly string bookingFile = Path.Combine(Application.StartupPath, "bookings.txt");

        

        private List<User> LoadUsers()
        {
            var users = new List<User>();
            if (!File.Exists(userFile)) return users;

            var lines = File.ReadAllLines(userFile);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var d = line.Split(',');

                if (d.Length >= 5)
                {
                    
                    users.Add(new User(
                        d[0].Trim(), // Email 
                        d[1].Trim(), // Password
                        d[2].Trim(), // Role
                        d[3].Trim(), // PhoneNumber
                        d[4].Trim()  // DisplayName
                    ));
                }
            }
            return users;
        }

        private void SaveUsers(List<User> users)
        {
            var lines = users.Select(u => $"{u.Username.Trim()},{u.Password},{u.Role.Trim()},{u.PhoneNumber.Trim()},{u.DisplayName.Trim()}");
            File.WriteAllLines(userFile, lines);
        }

        public bool RegisterUser(User u)
        {
            var users = LoadUsers();
            if (users.Any(user => user.Username.Equals(u.Username, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            users.Add(u);
            SaveUsers(users);
            return true;
        }

        public User Login(string email, string password)
        {
            var users = LoadUsers();

            string inputEmail = email.Trim();
            string inputPassword = password.Trim();

            return users.FirstOrDefault(u =>
                u.Username.Equals(inputEmail, StringComparison.OrdinalIgnoreCase) &&
                u.Password == inputPassword
            );
        }


        // ---------------- TRIP/BOOKING FUNCTIONS (Simplified for space) ----------------
        // (The full logic for AddTrip, SearchTrips, GetDriverTrips, BookRide, GetPassengerBookings remains the same 
        // as the last detailed Backend.cs code provided)

        private List<Trip> LoadTrips()
        {
            var trips = new List<Trip>();
            if (!File.Exists(tripFile)) return trips;

            var lines = File.ReadAllLines(tripFile);
            foreach (var line in lines)
            {
                var d = line.Split(',');
                if (d.Length == 6 && int.TryParse(d[5], out int seats))
                {
                    trips.Add(new Trip(d[0], d[1], d[2], d[3], d[4], seats));
                }
            }
            return trips;
        }

        private void SaveTrips(List<Trip> trips)
        {
            var lines = trips.Select(t => $"{t.TripId},{t.Driver},{t.Start},{t.Destination},{t.Time},{t.Seats}");
            File.WriteAllLines(tripFile, lines);
        }

        private List<Booking> LoadBookings()
        {
            var bookings = new List<Booking>();
            if (!File.Exists(bookingFile)) return bookings;

            var lines = File.ReadAllLines(bookingFile);
            foreach (var line in lines)
            {
                var d = line.Split(',');
                if (d.Length == 2)
                {
                    bookings.Add(new Booking(d[0], d[1]));
                }
            }
            return bookings;
        }

        public bool AddTrip(string driverEmail, string start, string destination, string time, int seats)
        {
            var trips = LoadTrips();
            string tripId = Guid.NewGuid().ToString().Substring(0, 8);
            var newTrip = new Trip(tripId, driverEmail, start, destination, time, seats);
            trips.Add(newTrip);
            SaveTrips(trips);
            return true;
        }

        public List<Trip> GetDriverTrips(string driverEmail)
        {
            return LoadTrips()
                       .Where(t => t.Driver.Equals(driverEmail, StringComparison.OrdinalIgnoreCase))
                       .ToList();
        }

        public List<Trip> SearchTrips(string destination)
        {
            var allUsers = LoadUsers();
            var searchResults = LoadTrips()
                       .Where(t => t.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase) && t.Seats > 0)
                       .ToList();

            foreach (var trip in searchResults)
            {
                var driverUser = allUsers.FirstOrDefault(u => u.Role == "Driver" && u.Username.Equals(trip.Driver, StringComparison.OrdinalIgnoreCase));
                if (driverUser != null)
                {
                    trip.DriverDisplayName = driverUser.DisplayName;
                    trip.DriverPhone = driverUser.PhoneNumber;
                }
                else
                {
                    trip.DriverDisplayName = "Unknown Driver";
                    trip.DriverPhone = "N/A";
                }
            }
            return searchResults;
        }

        public bool BookRide(string tripId, string passengerEmail)
        {
            var trips = LoadTrips();
            var trip = trips.FirstOrDefault(t => t.TripId == tripId && t.Seats > 0);
            if (trip == null) return false;

            var bookings = LoadBookings();
            if (bookings.Any(b => b.TripId == tripId && b.Passenger.Equals(passengerEmail, StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }

            trip.Seats -= 1;
            SaveTrips(trips);

            var newBooking = new Booking(tripId, passengerEmail);
            File.AppendAllText(bookingFile, $"{newBooking.TripId},{newBooking.Passenger}\n");

            return true;
        }

        public List<Trip> GetPassengerBookings(string passengerEmail)
        {
            var allBookings = LoadBookings();
            var allTrips = LoadTrips();
            var allUsers = LoadUsers();

            var bookedTrips = allBookings
                .Where(b => b.Passenger.Equals(passengerEmail, StringComparison.OrdinalIgnoreCase))
                .Join(allTrips,
                      booking => booking.TripId,
                      trip => trip.TripId,
                      (booking, trip) => trip)
                .ToList();

            foreach (var trip in bookedTrips) 
            {
                var driverUser = allUsers.FirstOrDefault(u => u.Role == "Driver" && u.Username.Equals(trip.Driver, StringComparison.OrdinalIgnoreCase));
                if (driverUser != null)
                {
                    trip.DriverDisplayName = driverUser.DisplayName;
                    trip.DriverPhone = driverUser.PhoneNumber;
                }
            }

            return bookedTrips;
        }
    }
}