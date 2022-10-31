using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    public partial class ConfirmCode : Form
    {
        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        public ConfirmCode(string activationcode, List<string> licnost)
        {
            InitializeComponent();         
            this.actcode = activationcode;
            this.lic = licnost;
        }

        public string actcode { get; set; }

        public List<string> lic { get; set; }

        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {
            if(textBoxCode.Texts != actcode)
            {
                MessageBox.Show("Activation code is incorrect");
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

                    sql = @"INSERT INTO Employee(Username, Name, Surname, Password, Id, Mail, PhoneNumber) VALUES (@username, @name, @surname, @password, @id, @mail, @phonenumber)";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@username", lic[0]);
                    cmd.Parameters.AddWithValue("@name", lic[1]);
                    cmd.Parameters.AddWithValue("@surname", lic[2]);
                    cmd.Parameters.AddWithValue("@password", lic[3]);
                    cmd.Parameters.AddWithValue("@id", lic[4]);
                    cmd.Parameters.AddWithValue("@mail", lic[5]);
                    cmd.Parameters.AddWithValue("@phonenumber", lic[6]);
                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Registered successfully!");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Username already exists, pick a new one!");
                }
            }          
        }
    }
}
