using System;
using System.Windows.Forms;
using RideShareApp.Backend;

namespace RideShareApp.Forms
{
    public partial class DriverTripsForm : Form
    {
        private string driverEmail;
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public DriverTripsForm(string email)
        {
            InitializeComponent();
            this.driverEmail = email;

            LoadDriverTrips();
        }

        private void LoadDriverTrips()
        {
            var trips = backend.GetDriverTrips(driverEmail);

            dgvDriverTrips.AutoGenerateColumns = false;
            dgvDriverTrips.DataSource = null;
            dgvDriverTrips.DataSource = trips;

            dgvDriverTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvDriverTrips.Columns.Contains("TripId")) dgvDriverTrips.Columns["TripId"].Visible = false;
            if (dgvDriverTrips.Columns.Contains("Driver")) dgvDriverTrips.Columns["Driver"].Visible = false;
            if (dgvDriverTrips.Columns.Contains("DriverDisplayName")) dgvDriverTrips.Columns["DriverDisplayName"].Visible = false;
            if (dgvDriverTrips.Columns.Contains("DriverPhone")) dgvDriverTrips.Columns["DriverPhone"].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DriverTripsForm_Load(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}