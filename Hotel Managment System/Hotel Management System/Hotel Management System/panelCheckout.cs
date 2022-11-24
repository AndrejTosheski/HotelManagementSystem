using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class panelCheckout : UserControl
    {
        public panelCheckout()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Room Number", 150);
            listView1.Columns.Add("Name", 150);
            listView1.Columns.Add("Surname", 150);
            listView1.Columns.Add("Age", 100);
            listView1.Columns.Add("EMBG", 200);
            listView1.Columns.Add("Phone Number", 150);
            listView1.Columns.Add("Mail", 300);
            listView1.Columns.Add("Booked From", 200);
            listView1.Columns.Add("Booked To", 200);
            listView1.Columns.Add("Duration (Days)", 150);
            listView1.Columns.Add("Total Cost", 150);
            RefreshList();
            
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dataReader;
            string sql;
            con = new SqlConnection(connectionString);
            con.Open();
            string temp = "01.1.1900 00:00:00";
            sql = "Select RoomNumber, Name, Surname, Age, EMBG, PhoneNumber, Mail, BookedFrom, BookedTo, Duration, TotalCost from Guests";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[11];
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
                arr[9] = dataReader.GetValue(9).ToString();
                arr[10] = dataReader.GetValue(10).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumFilter.Texts != "" && textBoxName.Texts != "" && textBoxSurname.Texts != "")
            {
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    listView1.Items.Clear();
                    con = new SqlConnection(connectionString);
                    con.Open();

                    sql = @"Select  RoomNumber, Name, Surname, Age, EMBG, PhoneNumber, Mail, BookedFrom, BookedTo, Duration, TotalCost FROM Guests WHERE RoomNumber = @roomnumber AND Name = @name AND Surname = @surname; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[3];

                    param[0] = new SqlParameter("@roomnumber", textBoxRoomNumFilter.Texts);
                    param[1] = new SqlParameter("@name", textBoxName.Texts);
                    param[2] = new SqlParameter("@surname", textBoxSurname.Texts);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    cmd.Parameters.Add(param[2]);
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[11];
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
                        arr[9] = dataReader.GetValue(9).ToString();
                        arr[10] = dataReader.GetValue(10).ToString();

                        itm = new ListViewItem(arr);
                        listView1.Items.Add(itm);
                    }
                    dataReader.Close();
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Missing information!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string roomnumber = listView1.SelectedItems[0].SubItems[0].Text;
                string name = listView1.SelectedItems[0].SubItems[1].Text;
                string surname = listView1.SelectedItems[0].SubItems[2].Text;
                string embg = listView1.SelectedItems[0].SubItems[4].Text;
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    con = new SqlConnection(connectionString);
                    con.Open();

                    //------------------------------------------------------------------------------
                    //Delete Guest

                    sql = @"DELETE FROM Guests WHERE RoomNumber = @roomnumber AND Name = @name AND Surname = @surname AND EMBG = @embg";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@embg", embg);
                    cmd.ExecuteNonQuery();

                    //------------------------------------------------------------------------------
                    //Check if there are any guests

                    sql = "SELECT count(*) FROM Guests WHERE Roomnumber = @roomnumber";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                    int NumberExist = (int)cmd.ExecuteScalar();
                    if (NumberExist == 0)
                    {
                        sql = "UPDATE Rooms SET RoomStatus = @roomstatus Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@roomstatus", "Available");
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE Rooms SET BookedFrom = @bookedfrom Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@bookedfrom", "");
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE Rooms SET BookedTo = @bookedto Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@bookedto", "");
                        cmd.ExecuteNonQuery();

                        sql = "UPDATE Rooms SET Duration = @duration Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@duration", 0);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        //-----------------------------------------------------------------------------
                        //Find the closest date booked

                        sql = @"SELECT MIN(BookedFrom) from Guests WHERE RoomNumber = @roomnumber;";
                        cmd = new SqlCommand(sql, con);
                        SqlParameter[] param = new SqlParameter[1];
                        string min = "";
                        param[0] = new SqlParameter("@roomnumber", roomnumber);
                        cmd.Parameters.Add(param[0]);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            min = dataReader.GetValue(0).ToString();
                        }
                        dataReader.Close();

                        sql = "UPDATE Rooms SET BookedFrom = @bookedfrom Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@bookedfrom", DateTime.Parse(min));
                        cmd.ExecuteNonQuery();

                        //-----------------------------------------------------------------------------
                        //Find the furthest date booked

                        sql = @"SELECT MAX(BookedTo) from Guests WHERE RoomNumber = @roomnumber;";
                        cmd = new SqlCommand(sql, con);
                        SqlParameter[] param2 = new SqlParameter[1];
                        string max = "";
                        param2[0] = new SqlParameter("@roomnumber", roomnumber);
                        cmd.Parameters.Add(param2[0]);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            max = dataReader.GetValue(0).ToString();
                        }
                        dataReader.Close();

                        sql = "UPDATE Rooms SET BookedTo = @bookedto Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@bookedto", DateTime.Parse(max));
                        cmd.ExecuteNonQuery();

                        //------------------------------------------------------------------------------
                        //Sum up the days

                        sql = @"SELECT SUM(Duration) FROM Guests WHERE RoomNumber = @roomnumber;";
                        cmd = new SqlCommand(sql, con);
                        string duration = "";
                        SqlParameter[] param3 = new SqlParameter[1];
                        param3[0] = new SqlParameter("@roomnumber", roomnumber);
                        cmd.Parameters.Add(param3[0]);
                        dataReader = cmd.ExecuteReader();
                        while (dataReader.Read())
                        {
                            duration = dataReader.GetValue(0).ToString();
                        }
                        dataReader.Close();

                        sql = "UPDATE Rooms SET Duration = @duration Where RoomNumber = @roomnumber";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", roomnumber);
                        cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(duration));
                        cmd.ExecuteNonQuery();                    
                    }                                                            

                    con.Close();
                    listView1.SelectedItems[0].Remove();
                    MessageBox.Show("Successful checkout!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string temp = "01.1.1900 00:00:00";
            sql = "Select RoomNumber, Name, Surname, Age, EMBG, PhoneNumber, Mail, BookedFrom, BookedTo, Duration, TotalCost from Guests";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[11];
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
                arr[9] = dataReader.GetValue(9).ToString();
                arr[10] = dataReader.GetValue(10).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }
    }
}
