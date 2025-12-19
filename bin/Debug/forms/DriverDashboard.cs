using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class DriverDashboard : Form
    {
        private string driverEmail;
        private string driverDisplayName;
        // No backend object needed here, only navigation

        public DriverDashboard(string email, string displayName) // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            this.driverEmail = email;
            this.driverDisplayName = displayName;

            // Ensure you have lblWelcome, btnPostTrip, btnMyTrips, btnLogout
            lblWelcome.Text = $"Welcome, {this.driverDisplayName}!";
            this.Text = $"Driver Dashboard - {this.driverDisplayName}";
        }

        private void btnPostTrip_Click(object sender, EventArgs e)
        {
            var postTrip = new PostTripForm(driverEmail);
            postTrip.Show();
        }

        private void btnMyTrips_Click(object sender, EventArgs e)
        {
            var driverTrips = new DriverTripsForm(driverEmail);
            driverTrips.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }

        private void DriverDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}