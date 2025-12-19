namespace RideShareApp.Forms
{
    partial class PassengerDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnSearchRide = new System.Windows.Forms.Button();
            this.btnMyBookings = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::RideShareApp.Properties.Resources.Gemini_Generated_Image_zb3bwczb3bwczb3b;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1027, 216);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 3;
            this.pbLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pbLogo);
            this.panel1.Location = new System.Drawing.Point(-1, -12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1027, 216);
            this.panel1.TabIndex = 4;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(302, 244);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(469, 85);
            this.lblWelcome.TabIndex = 5;
            this.lblWelcome.Text = "Welcome, Passenger!";
            // 
            // btnSearchRide
            // 
            this.btnSearchRide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSearchRide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearchRide.FlatAppearance.BorderSize = 0;
            this.btnSearchRide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSearchRide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnSearchRide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRide.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRide.ForeColor = System.Drawing.Color.Transparent;
            this.btnSearchRide.Location = new System.Drawing.Point(333, 332);
            this.btnSearchRide.Name = "btnSearchRide";
            this.btnSearchRide.Size = new System.Drawing.Size(359, 61);
            this.btnSearchRide.TabIndex = 6;
            this.btnSearchRide.Text = "Search For A Ride";
            this.btnSearchRide.UseVisualStyleBackColor = false;
            this.btnSearchRide.Click += new System.EventHandler(this.btnSearchRide_Click);
            // 
            // btnMyBookings
            // 
            this.btnMyBookings.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMyBookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyBookings.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyBookings.FlatAppearance.BorderSize = 0;
            this.btnMyBookings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMyBookings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnMyBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyBookings.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyBookings.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyBookings.Location = new System.Drawing.Point(333, 419);
            this.btnMyBookings.Name = "btnMyBookings";
            this.btnMyBookings.Size = new System.Drawing.Size(359, 61);
            this.btnMyBookings.TabIndex = 7;
            this.btnMyBookings.Text = "View My Bookings";
            this.btnMyBookings.UseVisualStyleBackColor = false;
            this.btnMyBookings.Click += new System.EventHandler(this.btnMyBookings_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogout.Location = new System.Drawing.Point(408, 523);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 52);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // PassengerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyBookings);
            this.Controls.Add(this.btnSearchRide);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Name = "PassengerDashboard";
            this.Text = "Passenger Dashboard";
            this.Load += new System.EventHandler(this.PassengerDashboard_Load);
            this.Click += new System.EventHandler(this.btnSearchRide_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnSearchRide;
        private System.Windows.Forms.Button btnMyBookings;
        private System.Windows.Forms.Button btnLogout;
    }
}