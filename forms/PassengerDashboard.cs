using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class PassengerDashboard : Form
    {
        private string passengerEmail;
        private string passengerDisplayName;
        
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public PassengerDashboard(string email, string displayName) // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            this.passengerEmail = email;
            this.passengerDisplayName = displayName;
            // Ensure you have lblWelcome, btnSearchRide, btnMyBookings, btnLogout
            lblWelcome.Text = $"Welcome, {this.passengerDisplayName}!";
            this.Text = $"Passenger Dashboard - {this.passengerDisplayName}";
        }

        private void btnSearchRide_Click(object sender, EventArgs e)
        {
            var searchRide = new SearchRideForm(passengerEmail);
            searchRide.Show();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            var passengerBookings = new PassengerBookingsForm(passengerEmail);
            passengerBookings.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void PassengerDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}