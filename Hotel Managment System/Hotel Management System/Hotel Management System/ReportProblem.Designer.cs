namespace Hotel_Management_System
{
    partial class ReportProblem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportProblem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new Hotel_Management_System.CustomControls.RJTextBox();
            this.buttonReport = new Hotel_Management_System.CustomControls.RJButton();
            this.comboBoxRoomStatus = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 30);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Room Number:";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.BackColor = System.Drawing.Color.White;
            this.textBoxRoomNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxRoomNumber.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxRoomNumber.BorderRadius = 15;
            this.textBoxRoomNumber.BorderSize = 2;
            this.textBoxRoomNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxRoomNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxRoomNumber.Location = new System.Drawing.Point(12, 42);
            this.textBoxRoomNumber.Multiline = false;
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxRoomNumber.PasswordChar = false;
            this.textBoxRoomNumber.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxRoomNumber.PlaceholderText = "";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(182, 34);
            this.textBoxRoomNumber.TabIndex = 19;
            this.textBoxRoomNumber.Texts = "";
            this.textBoxRoomNumber.UnderlinedStyle = false;
            // 
            // buttonReport
            // 
            this.buttonReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonReport.BorderRadius = 15;
            this.buttonReport.BorderSize = 0;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonReport.Location = new System.Drawing.Point(12, 151);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(182, 34);
            this.buttonReport.TabIndex = 27;
            this.buttonReport.Text = "Report";
            this.buttonReport.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonReport.UseVisualStyleBackColor = false;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // comboBoxRoomStatus
            // 
            this.comboBoxRoomStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxRoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.comboBoxRoomStatus.FormattingEnabled = true;
            this.comboBoxRoomStatus.Items.AddRange(new object[] {
            "Available",
            "Booked",
            "Closed "});
            this.comboBoxRoomStatus.Location = new System.Drawing.Point(16, 108);
            this.comboBoxRoomStatus.Name = "comboBoxRoomStatus";
            this.comboBoxRoomStatus.Size = new System.Drawing.Size(178, 27);
            this.comboBoxRoomStatus.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Room Status:";
            // 
            // ReportProblem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(209, 221);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxRoomStatus);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportProblem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJTextBox textBoxRoomNumber;
        private CustomControls.RJButton buttonReport;
        private System.Windows.Forms.ComboBox comboBoxRoomStatus;
        private System.Windows.Forms.Label label3;
    }
}