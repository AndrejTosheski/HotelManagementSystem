namespace Hotel_Management_System
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TabRooms = new Hotel_Management_System.CustomControls.RJButton();
            this.TabGuests = new Hotel_Management_System.CustomControls.RJButton();
            this.TabBookings = new Hotel_Management_System.CustomControls.RJButton();
            this.TabCheckout = new Hotel_Management_System.CustomControls.RJButton();
            this.TabDashboard = new Hotel_Management_System.CustomControls.RJButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonLogout = new Hotel_Management_System.CustomControls.RJButton();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel2.Name = "panel2";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panelMain);
            this.panel4.Controls.Add(this.flowLayoutPanel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // flowLayoutPanel1
            // 
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.flowLayoutPanel1.Controls.Add(this.TabRooms);
            this.flowLayoutPanel1.Controls.Add(this.TabGuests);
            this.flowLayoutPanel1.Controls.Add(this.TabBookings);
            this.flowLayoutPanel1.Controls.Add(this.TabCheckout);
            this.flowLayoutPanel1.Controls.Add(this.TabDashboard);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // TabRooms
            // 
            resources.ApplyResources(this.TabRooms, "TabRooms");
            this.TabRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabRooms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabRooms.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.TabRooms.BorderRadius = 20;
            this.TabRooms.BorderSize = 0;
            this.TabRooms.FlatAppearance.BorderSize = 0;
            this.TabRooms.ForeColor = System.Drawing.Color.White;
            this.TabRooms.Name = "TabRooms";
            this.TabRooms.TextColor = System.Drawing.Color.White;
            this.TabRooms.UseVisualStyleBackColor = false;
            this.TabRooms.Click += new System.EventHandler(this.TabRooms_Click);
            // 
            // TabGuests
            // 
            resources.ApplyResources(this.TabGuests, "TabGuests");
            this.TabGuests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabGuests.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabGuests.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.TabGuests.BorderRadius = 20;
            this.TabGuests.BorderSize = 0;
            this.TabGuests.FlatAppearance.BorderSize = 0;
            this.TabGuests.ForeColor = System.Drawing.Color.White;
            this.TabGuests.Name = "TabGuests";
            this.TabGuests.TextColor = System.Drawing.Color.White;
            this.TabGuests.UseVisualStyleBackColor = false;
            this.TabGuests.Click += new System.EventHandler(this.TabGuests_Click);
            // 
            // TabBookings
            // 
            resources.ApplyResources(this.TabBookings, "TabBookings");
            this.TabBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabBookings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabBookings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.TabBookings.BorderRadius = 20;
            this.TabBookings.BorderSize = 0;
            this.TabBookings.FlatAppearance.BorderSize = 0;
            this.TabBookings.ForeColor = System.Drawing.Color.White;
            this.TabBookings.Name = "TabBookings";
            this.TabBookings.TextColor = System.Drawing.Color.White;
            this.TabBookings.UseVisualStyleBackColor = false;
            this.TabBookings.Click += new System.EventHandler(this.TabBookings_Click);
            // 
            // TabCheckout
            // 
            resources.ApplyResources(this.TabCheckout, "TabCheckout");
            this.TabCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabCheckout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.TabCheckout.BorderRadius = 20;
            this.TabCheckout.BorderSize = 0;
            this.TabCheckout.FlatAppearance.BorderSize = 0;
            this.TabCheckout.ForeColor = System.Drawing.Color.White;
            this.TabCheckout.Name = "TabCheckout";
            this.TabCheckout.TextColor = System.Drawing.Color.White;
            this.TabCheckout.UseVisualStyleBackColor = false;
            this.TabCheckout.Click += new System.EventHandler(this.TabCheckout_Click);
            // 
            // TabDashboard
            // 
            resources.ApplyResources(this.TabDashboard, "TabDashboard");
            this.TabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.TabDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.TabDashboard.BorderRadius = 20;
            this.TabDashboard.BorderSize = 0;
            this.TabDashboard.FlatAppearance.BorderSize = 0;
            this.TabDashboard.ForeColor = System.Drawing.Color.White;
            this.TabDashboard.Name = "TabDashboard";
            this.TabDashboard.TextColor = System.Drawing.Color.White;
            this.TabDashboard.UseVisualStyleBackColor = false;
            this.TabDashboard.Click += new System.EventHandler(this.TabDashboard_Click);
            // 
            // panelMain
            // 
            resources.ApplyResources(this.panelMain, "panelMain");
            this.panelMain.Name = "panelMain";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Controls.Add(this.buttonLogout);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.buttonLogout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.buttonLogout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.buttonLogout.BorderRadius = 0;
            this.buttonLogout.BorderSize = 0;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonLogout, "buttonLogout");
            this.buttonLogout.ForeColor = System.Drawing.Color.White;
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.TextColor = System.Drawing.Color.White;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomControls.RJButton TabRooms;
        private CustomControls.RJButton TabGuests;
        private CustomControls.RJButton TabBookings;
        private CustomControls.RJButton TabCheckout;
        private CustomControls.RJButton TabDashboard;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel3;
        private CustomControls.RJButton buttonLogout;
    }
}

