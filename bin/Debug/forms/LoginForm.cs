using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class LoginForm : Form
    {
        // FIX: Using the fully qualified name to avoid CS0118 error
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public LoginForm() // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            // Ensure you have txtUsername, txtPassword, cmbRole, btnLogin, btnSignup
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString().Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = backend.Login(email, password);

            if (user == null)
            {
                MessageBox.Show("Invalid email or password.", "Login Failed");
                return;
            }
            if(!user.Role.Equals(role, StringComparison.OrdinalIgnoreCase))
{
                MessageBox.Show("Role mismatch. Please select the correct role.", "Login Failed");
                return;
            }

            string dashboardName = user.DisplayName;
            string userEmail = user.Username;

            if (user.Role == "Driver")
            {
                // Pass Email (for database lookup) and DisplayName (for welcome message)
                var dash = new DriverDashboard(userEmail, dashboardName);
                dash.Show();
                this.Hide();
            }
            else // Passenger
            {
                var dash = new PassengerDashboard(userEmail, dashboardName);
                dash.Show();
                this.Hide();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var signupForm = new SignupForm();
            signupForm.Show();
            this.Hide();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}