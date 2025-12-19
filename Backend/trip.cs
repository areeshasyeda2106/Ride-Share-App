namespace RideShareApp.Backend
{
    public class Trip
    {
        public string TripId { get; set; }
        public string Driver { get; set; } // Driver Email
        public string Start { get; set; }
        public string Destination { get; set; }
        public string Time { get; set; }
        public int Seats { get; set; }

        public string Price { get; set; }

        // Properties added for displaying to Passenger
        public string DriverDisplayName { get; set; }
        public string DriverPhone { get; set; }

        public Trip(string id, string driver, string start, string dest, string time, int seats, string driverDisplayName = "", string driverPhone = "",string price = null)
        {
            TripId = id;
            Driver = driver;
            Start = start;
            Destination = dest;
            Time = time;
            Seats = seats;
            DriverDisplayName = driverDisplayName;
            DriverPhone = driverPhone;
            Price = price;
        }
    }
}