namespace RideShareApp.Backend
{
    public class User
    {
        public string Username { get; set; } // Stores Email Address (unique ID)
        public string Password { get; set; }
        public string Role { get; set; } // "Driver" or "Passenger"
        public string PhoneNumber { get; set; } // Added for drivers
        public string DisplayName { get; set; } // Added for UI Welcome message

        public User(string email, string password, string role, string phoneNumber = "", string displayName = "")
        {
            Username = email;
            Password = password;
            Role = role;
            PhoneNumber = phoneNumber;
            DisplayName = displayName;
        }
    }
}