using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Texts == "" || textBoxNewPassword.Texts == "" || textBoxConfirmPassword.Texts == "" || textBoxId.Texts == "")
            {
                MessageBox.Show("Missing information!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (textBoxNewPassword.Texts != textBoxConfirmPassword.Texts)
                {
                    MessageBox.Show("Password doesn't match!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        SqlConnection con;
                        SqlCommand cmd;
                        string sql;
                        con = new SqlConnection(connectionString);
                        con.Open();

                        sql = "SELECT count(*) FROM Employee WHERE Username = @username";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@username", textBoxUsername.Texts);
                        int UserExist = (int)cmd.ExecuteScalar();

                        if (UserExist > 0)
                        {
                            sql = "UPDATE Employee SET Password = @password Where Username = @username AND Id = @id";
                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@username", textBoxUsername.Texts);
                            cmd.Parameters.AddWithValue("@id", textBoxId.Texts);
                            cmd.Parameters.AddWithValue("@password", textBoxNewPassword.Texts);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Password changed successfully!");
                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Username doesn't exist!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error!");
                    }
                }
            }           
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }
    }
}
