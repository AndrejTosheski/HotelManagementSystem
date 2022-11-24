namespace korisnichka_final
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelImeHotel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRoomType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDeparture = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonReserve = new Hotel_Management_System.CustomControls.RJButton();
            this.textBoxPhoneNumber = new Hotel_Management_System.CustomControls.RJTextBox();
            this.textBoxMail = new Hotel_Management_System.CustomControls.RJTextBox();
            this.textBoxEMBG = new Hotel_Management_System.CustomControls.RJTextBox();
            this.textBoxAge = new Hotel_Management_System.CustomControls.RJTextBox();
            this.textBoxSurname = new Hotel_Management_System.CustomControls.RJTextBox();
            this.textBoxName = new Hotel_Management_System.CustomControls.RJTextBox();
            this.panelImeHotel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelImeHotel
            // 
            this.panelImeHotel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.panelImeHotel.Controls.Add(this.label1);
            this.panelImeHotel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImeHotel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelImeHotel.Location = new System.Drawing.Point(0, 0);
            this.panelImeHotel.Name = "panelImeHotel";
            this.panelImeHotel.Size = new System.Drawing.Size(364, 44);
            this.panelImeHotel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label1.Location = new System.Drawing.Point(127, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 33);
            this.label1.TabIndex = 60;
            this.label1.Text = "Reserve";
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.dateTimePickerArrival.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerArrival.Location = new System.Drawing.Point(212, 343);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(140, 27);
            this.dateTimePickerArrival.TabIndex = 6;
            // 
            // comboBoxRoomType
            // 
            this.comboBoxRoomType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.comboBoxRoomType.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.comboBoxRoomType.FormattingEnabled = true;
            this.comboBoxRoomType.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Triple",
            "Quad"});
            this.comboBoxRoomType.Location = new System.Drawing.Point(12, 370);
            this.comboBoxRoomType.Name = "comboBoxRoomType";
            this.comboBoxRoomType.Size = new System.Drawing.Size(150, 27);
            this.comboBoxRoomType.TabIndex = 10;
            // 
            // dateTimePickerDeparture
            // 
            this.dateTimePickerDeparture.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.dateTimePickerDeparture.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeparture.Location = new System.Drawing.Point(212, 395);
            this.dateTimePickerDeparture.Name = "dateTimePickerDeparture";
            this.dateTimePickerDeparture.Size = new System.Drawing.Size(140, 27);
            this.dateTimePickerDeparture.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 61;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(206, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 62;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label4.Location = new System.Drawing.Point(18, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 63;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label5.Location = new System.Drawing.Point(18, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 64;
            this.label5.Text = "EMBG:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label6.Location = new System.Drawing.Point(18, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label7.Location = new System.Drawing.Point(206, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Phone Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label8.Location = new System.Drawing.Point(18, 348);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Room Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label9.Location = new System.Drawing.Point(208, 321);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Date of Arrival:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label10.Location = new System.Drawing.Point(208, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 19);
            this.label10.TabIndex = 69;
            this.label10.Text = "Date of Departure:";
            // 
            // buttonReserve
            // 
            this.buttonReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonReserve.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonReserve.BorderColor = System.Drawing.Color.White;
            this.buttonReserve.BorderRadius = 15;
            this.buttonReserve.BorderSize = 2;
            this.buttonReserve.FlatAppearance.BorderSize = 0;
            this.buttonReserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReserve.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonReserve.Location = new System.Drawing.Point(88, 451);
            this.buttonReserve.Name = "buttonReserve";
            this.buttonReserve.Size = new System.Drawing.Size(184, 51);
            this.buttonReserve.TabIndex = 59;
            this.buttonReserve.Text = "Send Reservation";
            this.buttonReserve.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonReserve.UseVisualStyleBackColor = false;
            this.buttonReserve.Click += new System.EventHandler(this.buttonReserve_Click);
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxPhoneNumber.BorderColor = System.Drawing.Color.White;
            this.textBoxPhoneNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxPhoneNumber.BorderRadius = 15;
            this.textBoxPhoneNumber.BorderSize = 2;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(203, 142);
            this.textBoxPhoneNumber.Multiline = false;
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxPhoneNumber.PasswordChar = false;
            this.textBoxPhoneNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxPhoneNumber.PlaceholderText = "";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(150, 34);
            this.textBoxPhoneNumber.TabIndex = 57;
            this.textBoxPhoneNumber.Texts = "";
            this.textBoxPhoneNumber.UnderlinedStyle = false;
            // 
            // textBoxMail
            // 
            this.textBoxMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxMail.BorderColor = System.Drawing.Color.White;
            this.textBoxMail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxMail.BorderRadius = 15;
            this.textBoxMail.BorderSize = 2;
            this.textBoxMail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxMail.Location = new System.Drawing.Point(12, 208);
            this.textBoxMail.Multiline = false;
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMail.PasswordChar = false;
            this.textBoxMail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMail.PlaceholderText = "";
            this.textBoxMail.Size = new System.Drawing.Size(340, 34);
            this.textBoxMail.TabIndex = 56;
            this.textBoxMail.Texts = "";
            this.textBoxMail.UnderlinedStyle = false;
            // 
            // textBoxEMBG
            // 
            this.textBoxEMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxEMBG.BorderColor = System.Drawing.Color.White;
            this.textBoxEMBG.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxEMBG.BorderRadius = 15;
            this.textBoxEMBG.BorderSize = 2;
            this.textBoxEMBG.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxEMBG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxEMBG.Location = new System.Drawing.Point(12, 273);
            this.textBoxEMBG.Multiline = false;
            this.textBoxEMBG.Name = "textBoxEMBG";
            this.textBoxEMBG.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxEMBG.PasswordChar = false;
            this.textBoxEMBG.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxEMBG.PlaceholderText = "";
            this.textBoxEMBG.Size = new System.Drawing.Size(340, 34);
            this.textBoxEMBG.TabIndex = 54;
            this.textBoxEMBG.Texts = "";
            this.textBoxEMBG.UnderlinedStyle = false;
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxAge.BorderColor = System.Drawing.Color.White;
            this.textBoxAge.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxAge.BorderRadius = 15;
            this.textBoxAge.BorderSize = 2;
            this.textBoxAge.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxAge.Location = new System.Drawing.Point(12, 142);
            this.textBoxAge.Multiline = false;
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxAge.PasswordChar = false;
            this.textBoxAge.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxAge.PlaceholderText = "";
            this.textBoxAge.Size = new System.Drawing.Size(150, 34);
            this.textBoxAge.TabIndex = 52;
            this.textBoxAge.Texts = "";
            this.textBoxAge.UnderlinedStyle = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxSurname.BorderColor = System.Drawing.Color.White;
            this.textBoxSurname.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxSurname.BorderRadius = 15;
            this.textBoxSurname.BorderSize = 2;
            this.textBoxSurname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxSurname.Location = new System.Drawing.Point(203, 76);
            this.textBoxSurname.Multiline = false;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxSurname.PasswordChar = false;
            this.textBoxSurname.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxSurname.PlaceholderText = "";
            this.textBoxSurname.Size = new System.Drawing.Size(150, 34);
            this.textBoxSurname.TabIndex = 43;
            this.textBoxSurname.Texts = "";
            this.textBoxSurname.UnderlinedStyle = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxName.BorderColor = System.Drawing.Color.White;
            this.textBoxName.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxName.BorderRadius = 15;
            this.textBoxName.BorderSize = 2;
            this.textBoxName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxName.Location = new System.Drawing.Point(12, 76);
            this.textBoxName.Multiline = false;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxName.PasswordChar = false;
            this.textBoxName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxName.PlaceholderText = "";
            this.textBoxName.Size = new System.Drawing.Size(150, 34);
            this.textBoxName.TabIndex = 42;
            this.textBoxName.Texts = "";
            this.textBoxName.UnderlinedStyle = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(364, 518);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonReserve);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxEMBG);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.dateTimePickerDeparture);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxRoomType);
            this.Controls.Add(this.dateTimePickerArrival);
            this.Controls.Add(this.panelImeHotel);
            this.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservation";
            this.panelImeHotel.ResumeLayout(false);
            this.panelImeHotel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelImeHotel;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrival;
        private System.Windows.Forms.ComboBox comboBoxRoomType;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxName;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxSurname;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeparture;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxAge;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxEMBG;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxMail;
        private Hotel_Management_System.CustomControls.RJTextBox textBoxPhoneNumber;
        private Hotel_Management_System.CustomControls.RJButton buttonReserve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

