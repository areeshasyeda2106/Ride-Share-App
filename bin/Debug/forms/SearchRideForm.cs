using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class SearchRideForm : Form
    {
        private string passengerEmail;
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public SearchRideForm(string email) // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            this.passengerEmail = email;
            // Ensure you have txtDestination, btnSearch, dgvTrips, btnBookRide
            btnBookRide.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string destination = txtDestination.Text.Trim();
            if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please enter a destination to search.", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var trips = backend.SearchTrips(destination);
            dgvTrips.DataSource = null;
            dgvTrips.AutoGenerateColumns = false;
            dgvTrips.DataSource = trips;

            // Hide the internal TripId and Driver Email columns from the passenger view
            if (dgvTrips.Columns.Contains("TripId")) dgvTrips.Columns["TripId"].Visible = false;
            if (dgvTrips.Columns.Contains("Driver")) dgvTrips.Columns["Driver"].Visible = false;

            if (trips.Count > 0)
            {
                btnBookRide.Enabled = true;
            }
            else
            {
                MessageBox.Show($"No available trips found for {destination}.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBookRide.Enabled = false;
            }
        }

        private void btnBookRide_Click(object sender, EventArgs e)
        {
            if (dgvTrips.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip to book.", "Booking Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedTrip = dgvTrips.SelectedRows[0].DataBoundItem as Trip;

            if (selectedTrip == null || selectedTrip.Seats <= 0)
            {
                MessageBox.Show("This trip is either full or details are missing.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult confirm = MessageBox.Show($"Confirm booking to {selectedTrip.Destination}? Driver: {selectedTrip.DriverDisplayName}. Contact: {selectedTrip.DriverPhone}", "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                if (backend.BookRide(selectedTrip.TripId, passengerEmail))
                {
                    MessageBox.Show("Ride booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the grid to show updated seat count
                    btnSearch_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Booking failed. You may have already booked this trip.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchRideForm_Load(object sender, EventArgs e)
        {

        }
    }
}