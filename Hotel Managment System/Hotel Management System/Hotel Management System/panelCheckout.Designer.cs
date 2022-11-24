namespace Hotel_Management_System
{
    partial class panelCheckout
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxSurname = new Hotel_Management_System.CustomControls.RJTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new Hotel_Management_System.CustomControls.RJTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonSearch = new Hotel_Management_System.CustomControls.RJButton();
            this.textBoxRoomNumFilter = new Hotel_Management_System.CustomControls.RJTextBox();
            this.buttonCheckout = new Hotel_Management_System.CustomControls.RJButton();
            this.buttonRefresh = new Hotel_Management_System.CustomControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1910, 68);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Hotel_Management_System.Properties.Resources.Checkout;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(94, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Checkout";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.listView1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 131);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1900, 743);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.groupBox3.Controls.Add(this.textBoxSurname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.textBoxName);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.textBoxRoomNumFilter);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.groupBox3.Location = new System.Drawing.Point(379, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(691, 51);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filter";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.White;
            this.textBoxSurname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxSurname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxSurname.BorderRadius = 15;
            this.textBoxSurname.BorderSize = 2;
            this.textBoxSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxSurname.Location = new System.Drawing.Point(465, 17);
            this.textBoxSurname.Multiline = false;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSurname.PasswordChar = false;
            this.textBoxSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSurname.PlaceholderText = "";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 34);
            this.textBoxSurname.TabIndex = 48;
            this.textBoxSurname.Texts = "";
            this.textBoxSurname.UnderlinedStyle = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(389, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(225, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxName.BorderRadius = 15;
            this.textBoxName.BorderSize = 2;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxName.Location = new System.Drawing.Point(283, 17);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.Size = new System.Drawing.Size(100, 34);
            this.textBoxName.TabIndex = 45;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(6, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 19);
            this.label15.TabIndex = 44;
            this.label15.Text = "Room Number:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSearch.BorderRadius = 15;
            this.buttonSearch.BorderSize = 2;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSearch.Location = new System.Drawing.Point(571, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 34);
            this.buttonSearch.TabIndex = 8;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxRoomNumFilter
            // 
            this.textBoxRoomNumFilter.BackColor = System.Drawing.Color.White;
            this.textBoxRoomNumFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxRoomNumFilter.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxRoomNumFilter.BorderRadius = 15;
            this.textBoxRoomNumFilter.BorderSize = 2;
            this.textBoxRoomNumFilter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxRoomNumFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxRoomNumFilter.Location = new System.Drawing.Point(119, 17);
            this.textBoxRoomNumFilter.Multiline = false;
            this.textBoxRoomNumFilter.Name = "textBoxRoomNumFilter";
            this.textBoxRoomNumFilter.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxRoomNumFilter.PasswordChar = false;
            this.textBoxRoomNumFilter.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxRoomNumFilter.PlaceholderText = "";
            this.textBoxRoomNumFilter.Size = new System.Drawing.Size(100, 34);
            this.textBoxRoomNumFilter.TabIndex = 12;
            this.textBoxRoomNumFilter.Texts = "";
            this.textBoxRoomNumFilter.UnderlinedStyle = false;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonCheckout.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonCheckout.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonCheckout.BorderRadius = 0;
            this.buttonCheckout.BorderSize = 2;
            this.buttonCheckout.FlatAppearance.BorderSize = 0;
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCheckout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonCheckout.Location = new System.Drawing.Point(191, 67);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(175, 65);
            this.buttonCheckout.TabIndex = 25;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonRefresh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonRefresh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonRefresh.BorderRadius = 0;
            this.buttonRefresh.BorderSize = 2;
            this.buttonRefresh.FlatAppearance.BorderSize = 0;
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonRefresh.Location = new System.Drawing.Point(10, 67);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(181, 65);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel2.Location = new System.Drawing.Point(364, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 65);
            this.panel2.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Location = new System.Drawing.Point(1069, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 65);
            this.panel3.TabIndex = 50;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel4.Location = new System.Drawing.Point(0, 68);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 829);
            this.panel4.TabIndex = 51;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel5.Location = new System.Drawing.Point(1910, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 829);
            this.panel5.TabIndex = 52;
            // 
            // panelCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panelCheckout";
            this.Size = new System.Drawing.Size(1910, 900);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private CustomControls.RJButton buttonRefresh;
        private CustomControls.RJButton buttonCheckout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private CustomControls.RJButton buttonSearch;
        private CustomControls.RJTextBox textBoxRoomNumFilter;
        private CustomControls.RJTextBox textBoxName;
        private CustomControls.RJTextBox textBoxSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
