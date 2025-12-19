namespace RideShareApp.Forms
{
    partial class DriverDashboard
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnPostTrip = new System.Windows.Forms.Button();
            this.btnMyTrips = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pbLogo);
            this.panel2.Location = new System.Drawing.Point(-9, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 203);
            this.panel2.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::RideShareApp.Properties.Resources.Gemini_Generated_Image_zb3bwczb3bwczb3b;
            this.pbLogo.InitialImage = null;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(1036, 203);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(332, 235);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(533, 85);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome, Driver!";
            // 
            // btnPostTrip
            // 
            this.btnPostTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPostTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostTrip.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPostTrip.FlatAppearance.BorderSize = 0;
            this.btnPostTrip.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPostTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnPostTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostTrip.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostTrip.ForeColor = System.Drawing.Color.Transparent;
            this.btnPostTrip.Location = new System.Drawing.Point(341, 323);
            this.btnPostTrip.Name = "btnPostTrip";
            this.btnPostTrip.Size = new System.Drawing.Size(322, 61);
            this.btnPostTrip.TabIndex = 4;
            this.btnPostTrip.Text = "Post A New Trip";
            this.btnPostTrip.UseVisualStyleBackColor = false;
            this.btnPostTrip.Click += new System.EventHandler(this.btnPostTrip_Click);
            // 
            // btnMyTrips
            // 
            this.btnMyTrips.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMyTrips.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyTrips.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMyTrips.FlatAppearance.BorderSize = 0;
            this.btnMyTrips.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnMyTrips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnMyTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyTrips.Font = new System.Drawing.Font("Wingdings", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyTrips.ForeColor = System.Drawing.Color.Transparent;
            this.btnMyTrips.Location = new System.Drawing.Point(341, 404);
            this.btnMyTrips.Name = "btnMyTrips";
            this.btnMyTrips.Size = new System.Drawing.Size(322, 61);
            this.btnMyTrips.TabIndex = 5;
            this.btnMyTrips.Text = "View My Trips";
            this.btnMyTrips.UseVisualStyleBackColor = false;
            this.btnMyTrips.Click += new System.EventHandler(this.btnMyTrips_Click);
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
            this.btnLogout.Location = new System.Drawing.Point(409, 503);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(193, 52);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DriverDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMyTrips);
            this.Controls.Add(this.btnPostTrip);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel2);
            this.Name = "DriverDashboard";
            this.Text = "Driver Dashboard";
            this.Load += new System.EventHandler(this.DriverDashboard_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnPostTrip;
        private System.Windows.Forms.Button btnMyTrips;
        private System.Windows.Forms.Button btnLogout;
    }
}