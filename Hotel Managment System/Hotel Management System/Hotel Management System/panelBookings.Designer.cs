namespace Hotel_Management_System
{
    partial class panelBookings
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
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxMailTo = new Hotel_Management_System.CustomControls.RJTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxMailSubject = new Hotel_Management_System.CustomControls.RJTextBox();
            this.buttonSend = new Hotel_Management_System.CustomControls.RJButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMailBody = new Hotel_Management_System.CustomControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMailFrom = new Hotel_Management_System.CustomControls.RJTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDelete = new Hotel_Management_System.CustomControls.RJButton();
            this.buttonApprove = new Hotel_Management_System.CustomControls.RJButton();
            this.buttonRefresh = new Hotel_Management_System.CustomControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.pictureBox3.Image = global::Hotel_Management_System.Properties.Resources.Bookings;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 71);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
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
            this.label1.Size = new System.Drawing.Size(137, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bookings";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(123)))), ((int)(((byte)(152)))));
            this.listView1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(424, 158);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1496, 716);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label13.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label13.Location = new System.Drawing.Point(144, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 33);
            this.label13.TabIndex = 25;
            this.label13.Text = "Send Mail";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxMailTo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBoxMailSubject);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMailBody);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMailFrom);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.groupBox1.Location = new System.Drawing.Point(10, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 523);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mail";
            // 
            // textBoxMailTo
            // 
            this.textBoxMailTo.BackColor = System.Drawing.Color.White;
            this.textBoxMailTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxMailTo.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxMailTo.BorderRadius = 15;
            this.textBoxMailTo.BorderSize = 2;
            this.textBoxMailTo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMailTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxMailTo.Location = new System.Drawing.Point(36, 131);
            this.textBoxMailTo.Multiline = false;
            this.textBoxMailTo.Name = "textBoxMailTo";
            this.textBoxMailTo.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMailTo.PasswordChar = false;
            this.textBoxMailTo.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMailTo.PlaceholderText = "";
            this.textBoxMailTo.Size = new System.Drawing.Size(326, 34);
            this.textBoxMailTo.TabIndex = 44;
            this.textBoxMailTo.Texts = "";
            this.textBoxMailTo.UnderlinedStyle = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(44, 184);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 19);
            this.label12.TabIndex = 43;
            this.label12.Text = "Subject:";
            // 
            // textBoxMailSubject
            // 
            this.textBoxMailSubject.BackColor = System.Drawing.Color.White;
            this.textBoxMailSubject.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxMailSubject.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxMailSubject.BorderRadius = 15;
            this.textBoxMailSubject.BorderSize = 2;
            this.textBoxMailSubject.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMailSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxMailSubject.Location = new System.Drawing.Point(36, 206);
            this.textBoxMailSubject.Multiline = false;
            this.textBoxMailSubject.Name = "textBoxMailSubject";
            this.textBoxMailSubject.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMailSubject.PasswordChar = false;
            this.textBoxMailSubject.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMailSubject.PlaceholderText = "";
            this.textBoxMailSubject.Size = new System.Drawing.Size(326, 34);
            this.textBoxMailSubject.TabIndex = 41;
            this.textBoxMailSubject.Texts = "";
            this.textBoxMailSubject.UnderlinedStyle = false;
            // 
            // buttonSend
            // 
            this.buttonSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonSend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonSend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSend.BorderRadius = 15;
            this.buttonSend.BorderSize = 2;
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSend.Location = new System.Drawing.Point(100, 454);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(182, 51);
            this.buttonSend.TabIndex = 30;
            this.buttonSend.Text = "Send";
            this.buttonSend.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(44, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "From:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(44, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Body:";
            // 
            // textBoxMailBody
            // 
            this.textBoxMailBody.BackColor = System.Drawing.Color.White;
            this.textBoxMailBody.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxMailBody.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxMailBody.BorderRadius = 15;
            this.textBoxMailBody.BorderSize = 2;
            this.textBoxMailBody.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMailBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxMailBody.Location = new System.Drawing.Point(36, 287);
            this.textBoxMailBody.Multiline = true;
            this.textBoxMailBody.Name = "textBoxMailBody";
            this.textBoxMailBody.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMailBody.PasswordChar = false;
            this.textBoxMailBody.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMailBody.PlaceholderText = "";
            this.textBoxMailBody.Size = new System.Drawing.Size(326, 149);
            this.textBoxMailBody.TabIndex = 34;
            this.textBoxMailBody.Texts = "";
            this.textBoxMailBody.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(44, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "To:";
            // 
            // textBoxMailFrom
            // 
            this.textBoxMailFrom.BackColor = System.Drawing.Color.White;
            this.textBoxMailFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.textBoxMailFrom.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxMailFrom.BorderRadius = 15;
            this.textBoxMailFrom.BorderSize = 2;
            this.textBoxMailFrom.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxMailFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxMailFrom.Location = new System.Drawing.Point(36, 60);
            this.textBoxMailFrom.Multiline = false;
            this.textBoxMailFrom.Name = "textBoxMailFrom";
            this.textBoxMailFrom.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxMailFrom.PasswordChar = false;
            this.textBoxMailFrom.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxMailFrom.PlaceholderText = "";
            this.textBoxMailFrom.Size = new System.Drawing.Size(326, 34);
            this.textBoxMailFrom.TabIndex = 32;
            this.textBoxMailFrom.Texts = "hotelmanagementsystem281203@gmail.com";
            this.textBoxMailFrom.UnderlinedStyle = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel3.Location = new System.Drawing.Point(414, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 822);
            this.panel3.TabIndex = 45;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel6.Location = new System.Drawing.Point(423, 148);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1497, 10);
            this.panel6.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel2.Location = new System.Drawing.Point(0, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 822);
            this.panel2.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.panel4.Location = new System.Drawing.Point(9, 678);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(409, 10);
            this.panel4.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.label3.Location = new System.Drawing.Point(83, 701);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 33);
            this.label3.TabIndex = 48;
            this.label3.Text = "Approve Reservation";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonDelete.BorderRadius = 0;
            this.buttonDelete.BorderSize = 2;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonDelete.Location = new System.Drawing.Point(627, 68);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(200, 80);
            this.buttonDelete.TabIndex = 49;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonApprove
            // 
            this.buttonApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonApprove.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonApprove.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonApprove.BorderRadius = 15;
            this.buttonApprove.BorderSize = 2;
            this.buttonApprove.FlatAppearance.BorderSize = 0;
            this.buttonApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonApprove.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonApprove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonApprove.Location = new System.Drawing.Point(110, 772);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(182, 51);
            this.buttonApprove.TabIndex = 45;
            this.buttonApprove.Text = "Approve";
            this.buttonApprove.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonApprove.UseVisualStyleBackColor = false;
            this.buttonApprove.Click += new System.EventHandler(this.buttonApprove_Click);
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
            this.buttonRefresh.Location = new System.Drawing.Point(424, 68);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(203, 80);
            this.buttonRefresh.TabIndex = 24;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "panelBookings";
            this.Size = new System.Drawing.Size(1910, 900);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private CustomControls.RJButton buttonRefresh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private CustomControls.RJTextBox textBoxMailSubject;
        private CustomControls.RJButton buttonSend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJTextBox textBoxMailBody;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJTextBox textBoxMailFrom;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private CustomControls.RJTextBox textBoxMailTo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private CustomControls.RJButton buttonApprove;
        private CustomControls.RJButton buttonDelete;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
