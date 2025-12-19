using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class PassengerBookingsForm : Form
    {
        private string passengerEmail;
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public PassengerBookingsForm(string email) // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            this.passengerEmail = email;
            // Ensure you have dgvBookings, btnBack
            LoadBookings();
        }

        private void LoadBookings()
        {
            var bookings = backend.GetPassengerBookings(passengerEmail);
            dgvBookings.DataSource = null;
            dgvBookings.AutoGenerateColumns = false;
            dgvBookings.DataSource = bookings;
            // Hide the internal columns
            if (dgvBookings.Columns.Contains("TripId")) dgvBookings.Columns["TripId"].Visible = false;
            if (dgvBookings.Columns.Contains("Driver")) dgvBookings.Columns["Driver"].Visible = false;
            if (dgvBookings.Columns.Contains("Seats")) dgvBookings.Columns["Seats"].Visible = false; // Seats is irrelevant here

            if (bookings.Count == 0)
            {
                // Show message, but keep form open
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PassengerBookingsForm_Load(object sender, EventArgs e)
        {

        }
    }
}