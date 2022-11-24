using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class panelBookings : UserControl
    {
        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        public panelBookings()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Surname", 150);
            listView1.Columns.Add("Age", 120);
            listView1.Columns.Add("EMBG", 200);
            listView1.Columns.Add("Phone Number", 150);
            listView1.Columns.Add("Mail", 300);
            listView1.Columns.Add("Room Type", 150);
            listView1.Columns.Add("Booked From", 145);
            listView1.Columns.Add("Booked To", 145);
            RefreshList();          
        }
        public panelBookings(string msg)
        {
            message = msg;
            CreateTable();
            InsertToDatabase();
        }

        public static string message { get; set; }


        public static void InsertToDatabase()
        {         
            try
            {
                string[] subs = message.Split();
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();
                sql = @"INSERT INTO Bookings(Name, Surname, Age, EMBG, PhoneNumber, Mail, RoomType, BookedFrom, BookedTo) VALUES (@name, @surname, @age, @embg, @phonenumber, @mail, @roomtype, @bookedfrom, @bookedto)";
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", subs[0]);
                cmd.Parameters.AddWithValue("@surname", subs[1]);
                cmd.Parameters.AddWithValue("@age", subs[2]);
                cmd.Parameters.AddWithValue("@embg", subs[3]);
                cmd.Parameters.AddWithValue("@phonenumber", subs[4]);
                cmd.Parameters.AddWithValue("@mail", subs[5]);
                cmd.Parameters.AddWithValue("@roomtype", subs[6]);
                cmd.Parameters.AddWithValue("@bookedfrom", subs[7]);
                cmd.Parameters.AddWithValue("@bookedto", subs[8]);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }          
        }
        public static void CreateTable()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('Bookings')";
                cmd = new SqlCommand(sql, con);
                int newProdID = (Int32)cmd.ExecuteScalar();
                if ((Int32)cmd.ExecuteScalar() == 0)
                {
                    sql = "CREATE TABLE Bookings" + "(Name CHAR(255), Surname CHAR(255), Age CHAR(255), EMBG CHAR(255), PhoneNumber CHAR(255), Mail CHAR(255), RoomType CHAR(255), BookedFrom DATE, BookedTo DATE)";
                    cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();

                }
                con.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            con = new SqlConnection(connectionString);
            con.Open();
            sql = "Select Name, Surname, Age, EMBG, PhoneNumber, Mail, RoomType, BookedFrom, BookedTo from Bookings";
            cmd = new SqlCommand(sql, con);
            string temp = "";
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[9];
                ListViewItem itm;
                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();
                arr[3] = dataReader.GetValue(3).ToString();
                arr[4] = dataReader.GetValue(4).ToString();
                arr[5] = dataReader.GetValue(5).ToString();
                arr[6] = dataReader.GetValue(6).ToString();
                arr[7] = dataReader.GetValue(7).ToString();
                if (arr[7] == temp)
                {
                    arr[7] = "";
                }
                else
                {
                    string temp2 = arr[7];
                    string final = "";
                    for (int i = 0; i < temp2.Length; i++)
                    {
                        if (temp2[i] != 32)
                        {
                            final += temp2[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    arr[7] = final;
                }
                arr[8] = dataReader.GetValue(8).ToString();
                if (arr[8] == temp)
                {
                    arr[8] = "";
                }
                else
                {
                    string temp2 = arr[8];
                    string final = "";
                    for (int i = 0; i < temp2.Length; i++)
                    {
                        if (temp2[i] != 32)
                        {
                            final += temp2[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    arr[8] = final;
                }

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {          
            using (MailMessage mm = new MailMessage(textBoxMailFrom.Texts.Trim(), textBoxMailTo.Texts.Trim()))
            {
                mm.Subject = textBoxMailSubject.Texts;
                mm.Body = textBoxMailBody.Texts;              
                mm.IsBodyHtml = false;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential NetworkCred = new NetworkCredential(textBoxMailFrom.Texts.Trim(), "cgqxngfmyssjtxpz");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = NetworkCred;
                smtp.Port = 587;
                smtp.Send(mm);
                MessageBox.Show("Email sent.", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string row = listView1.SelectedItems[0].SubItems[3].Text;
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    string sql;
                    con = new SqlConnection(connectionString);
                    con.Open();

                    sql = @"DELETE FROM Bookings WHERE EMBG = @embg";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@embg", row);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    listView1.SelectedItems[0].Remove();
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("You have to select a row from the table!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string row = listView1.SelectedItems[0].SubItems[3].Text;
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    con = new SqlConnection(connectionString);
                    con.Open();
                    sql = "Select Name, Surname, Age, EMBG, PhoneNumber, Mail, RoomType, BookedFrom, BookedTo from Bookings WHERE EMBG = @embg";
                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[1];
                    param[0] = new SqlParameter("@embg", row);
                    cmd.Parameters.Add(param[0]);
                    dataReader = cmd.ExecuteReader();
                    string info = "";
                    while (dataReader.Read())
                    {                       
                        info += dataReader.GetValue(0).ToString().Trim();
                        info += " " + dataReader.GetValue(1).ToString().Trim();
                        info += " " + dataReader.GetValue(2).ToString().Trim();
                        info += " " + dataReader.GetValue(3).ToString().Trim();
                        info += " " + dataReader.GetValue(4).ToString().Trim();
                        info += " " + dataReader.GetValue(5).ToString().Trim(); 
                        info += " " + dataReader.GetValue(6).ToString().Trim();
                        info += " " + dataReader.GetValue(7).ToString().Trim();
                        info += " " + dataReader.GetValue(8).ToString().Trim();                  
                    }
                    dataReader.Close();
                    con.Close();
                    panelRooms obj = new panelRooms(info);
                }
                catch
                {
                    MessageBox.Show("Error!");
                }
            }
            else
            {
                MessageBox.Show("You have to select a row from the table!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RefreshList()
        {
            listView1.Items.Clear();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            con = new SqlConnection(connectionString);
            con.Open();
            sql = "Select Name, Surname, Age, EMBG, PhoneNumber, Mail, RoomType, BookedFrom, BookedTo from Bookings";
            cmd = new SqlCommand(sql, con);
            string temp = "";
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[9];
                ListViewItem itm;
                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();
                arr[3] = dataReader.GetValue(3).ToString();
                arr[4] = dataReader.GetValue(4).ToString();
                arr[5] = dataReader.GetValue(5).ToString();
                arr[6] = dataReader.GetValue(6).ToString();
                arr[7] = dataReader.GetValue(7).ToString();
                if (arr[7] == temp)
                {
                    arr[7] = "";
                }
                else
                {
                    string temp2 = arr[7];
                    string final = "";
                    for (int i = 0; i < temp2.Length; i++)
                    {
                        if (temp2[i] != 32)
                        {
                            final += temp2[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    arr[7] = final;
                }
                arr[8] = dataReader.GetValue(8).ToString();
                if (arr[8] == temp)
                {
                    arr[8] = "";
                }
                else
                {
                    string temp2 = arr[8];
                    string final = "";
                    for (int i = 0; i < temp2.Length; i++)
                    {
                        if (temp2[i] != 32)
                        {
                            final += temp2[i];
                        }
                        else
                        {
                            break;
                        }
                    }
                    arr[8] = final;
                }

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }
    }
}
