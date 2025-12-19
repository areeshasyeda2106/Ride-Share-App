using System;
using System.Windows.Forms;
using RideShareApp.Backend; // Required

namespace RideShareApp.Forms
{
    public partial class SignupForm : Form
    {
        RideShareApp.Backend.Backend backend = new RideShareApp.Backend.Backend();

        public SignupForm() // FIX: Ensures constructor is present to fix CS0115
        {
            InitializeComponent();
            cmbRole.SelectedIndex = 0;
            // Ensure you have txtUsername, txtName, txtPassword, cmbRole, txtPhoneNumber, btnCreateAccount
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string email = txtUsername.Text.Trim();
            string name = txtName.Text.Trim();
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();
            string phoneNumber = role == "Driver" ? txtPhoneNumber.Text.Trim() : "";

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Email, Name, Password, and Role are required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (role == "Driver" && string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Drivers must provide a Phone Number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newUser = new User(email, password, role, phoneNumber, name);

            if (backend.RegisterUser(newUser))
            {
                MessageBox.Show("Account created successfully. You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Email already registered.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignupForm_Load(object sender, EventArgs e)
        {

        }

        private void pbLogo_Click(object sender, EventArgs e)
        {

        }
    }
}