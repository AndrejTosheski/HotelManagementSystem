namespace Hotel_Management_System
{
    partial class ConfirmCode
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
            this.buttonConfirmCode = new Hotel_Management_System.CustomControls.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCode = new Hotel_Management_System.CustomControls.RJTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonConfirmCode.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(137)))), ((int)(((byte)(184)))));
            this.buttonConfirmCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonConfirmCode.BorderRadius = 15;
            this.buttonConfirmCode.BorderSize = 0;
            this.buttonConfirmCode.FlatAppearance.BorderSize = 0;
            this.buttonConfirmCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.buttonConfirmCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonConfirmCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonConfirmCode.Location = new System.Drawing.Point(34, 78);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(220, 30);
            this.buttonConfirmCode.TabIndex = 23;
            this.buttonConfirmCode.Text = "Enter";
            this.buttonConfirmCode.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.buttonConfirmCode.UseVisualStyleBackColor = false;
            this.buttonConfirmCode.Click += new System.EventHandler(this.buttonConfirmCode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-4, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 37);
            this.panel1.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(58, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Enter Confirmation Code";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.textBoxCode.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(96)))), ((int)(((byte)(10)))));
            this.textBoxCode.BorderRadius = 15;
            this.textBoxCode.BorderSize = 2;
            this.textBoxCode.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.textBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.textBoxCode.Location = new System.Drawing.Point(34, 38);
            this.textBoxCode.Multiline = false;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxCode.PasswordChar = false;
            this.textBoxCode.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBoxCode.PlaceholderText = "";
            this.textBoxCode.Size = new System.Drawing.Size(220, 34);
            this.textBoxCode.TabIndex = 26;
            this.textBoxCode.Texts = "";
            this.textBoxCode.UnderlinedStyle = false;
            // 
            // ConfirmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(40)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(284, 116);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonConfirmCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConfirmCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfirmCode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJButton buttonConfirmCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private CustomControls.RJTextBox textBoxCode;
    }
}