using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class PostTripForm : Form
    {
        private string driverEmail;
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public PostTripForm(string email) // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            this.driverEmail = email;
            // Ensure you have txtStart, txtDestination, txtTime, txtSeats, btnSaveTrip
        }

        private void btnSaveTrip_Click(object sender, EventArgs e)
        {
            string start = txtStart.Text.Trim();
            string destination = txtDestination.Text.Trim();
            string time = txtTime.Text.Trim();
            string seatsText = txtSeats.Text.Trim();

            if (string.IsNullOrWhiteSpace(start) || string.IsNullOrWhiteSpace(destination) || string.IsNullOrWhiteSpace(time) || string.IsNullOrWhiteSpace(seatsText))
            {
                MessageBox.Show("All fields are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(seatsText, out int seats) || seats <= 0)
            {
                MessageBox.Show("Seats must be a positive number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                backend.AddTrip(driverEmail, start, destination, time, seats);
                MessageBox.Show("Trip posted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PostTripForm_Load(object sender, EventArgs e)
        {

        }
    }
}