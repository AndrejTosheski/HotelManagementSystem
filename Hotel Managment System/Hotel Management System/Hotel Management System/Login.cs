using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Hotel_Management_System
{  
    public partial class Login : Form
    {
        public static Thread thread;
        public Login()
        {
            InitializeComponent();          
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
    
        private void buttonLogin_Click(object sender, EventArgs e)
        {          
            if (textBoxUsername.Texts == "" || textBoxPassword.Texts == "")
            {
                MessageBox.Show("Missing information!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    string[] info = new string[2];

                    con = new SqlConnection(connectionString);
                    con.Open();

                    sql = @"Select  Username, Password FROM Employee WHERE Username = @username AND Password = @password; ";
                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[2];

                    param[0] = new SqlParameter("@username", textBoxUsername.Texts);
                    param[1] = new SqlParameter("@password", textBoxPassword.Texts);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);

                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        info[0] = dataReader.GetValue(0).ToString();
                        info[1] = dataReader.GetValue(1).ToString();
                    }
                    for (int i = 0; i < info.Length; i++)
                    {
                        if (info[i].Trim() == textBoxUsername.Texts && info[i + 1].Trim() == textBoxPassword.Texts)
                        {
                            Main obj = new Main(info[i]);
                            obj.Show();
                            this.Hide();                          
                        }
                    }
                    dataReader.Close();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Wrong username or password!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }      

        private void linkLabel1ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword obj = new ChangePassword();
            obj.Show();
            this.Hide();
        }
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            this.Hide();
            obj.Show();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
