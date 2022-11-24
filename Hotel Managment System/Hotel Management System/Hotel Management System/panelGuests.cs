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
    public partial class panelGuests : UserControl
    {
        public panelGuests()
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
            if (textBoxRoomNumFilter.Texts != "")
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

                    sql = @"Select  RoomNumber, Name, Surname, Age, EMBG, PhoneNumber, Mail, BookedFrom, BookedTo, Duration, TotalCost FROM Guests WHERE RoomNumber = @roomnumber; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@roomnumber", textBoxRoomNumFilter.Texts);
                    cmd.Parameters.Add(param[0]);
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
