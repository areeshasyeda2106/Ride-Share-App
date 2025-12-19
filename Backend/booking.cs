namespace RideShareApp.Backend
{
    public class Booking
    {
        public string TripId { get; set; }
        public string Passenger { get; set; } // Stores Passenger Email

        public Booking(string tripId, string passenger)
        {
            TripId = tripId;
            Passenger = passenger;
        }
    }
}