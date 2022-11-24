using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hotel_Management_System
{
    public partial class panelRooms : UserControl
    {
        public panelRooms()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("Room Number", 200);
            listView1.Columns.Add("Room Type", 200);
            listView1.Columns.Add("Room Status", 200);
            listView1.Columns.Add("Booked From", 200);
            listView1.Columns.Add("Booked To", 200);
            listView1.Columns.Add("Duration (Days)", 200);
            listView1.Columns.Add("Room Cost", 210);
            RefreshList();        
        }

        public panelRooms(string inf)
        {
            info = inf;           
        }
        public static string info { get; set; }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        public struct Rooms
        {
            public string roomNumber;
            public string roomType;
            public string roomStatus;
            public string roomBookDate;
            public string roomDuration;
            public string roomCost;           
        };                    

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
            sql = "Select RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost from Rooms";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[7];
                ListViewItem itm;
                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();
                arr[3] = dataReader.GetValue(3).ToString();
                if (arr[3] == temp)
                {
                    arr[3] = "";
                }
                else
                {
                    string temp2 = arr[3];
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
                    arr[3] = final;
                }
                arr[4] = dataReader.GetValue(4).ToString();
                if (arr[4] == temp)
                {
                    arr[4] = "";
                }
                else
                {
                    string temp2 = arr[4];
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
                    arr[4] = final;
                }
                arr[5] = dataReader.GetValue(5).ToString();
                arr[6] = dataReader.GetValue(6).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            AddRoom obj = new AddRoom();
            obj.Show();           
        }

        private void buttonDeleteRoom_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                string row = listView1.SelectedItems[0].SubItems[0].Text;
                try
                {
                    SqlConnection con;
                    SqlCommand cmd;
                    string sql;
                    con = new SqlConnection(connectionString);
                    con.Open();

                    sql = @"DELETE FROM Rooms WHERE RoomNumber = @roomnumber";
                    cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@roomnumber", row);
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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (radioButtonAvailable.Checked)
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
                    
                    sql = @"Select  RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost FROM Rooms WHERE RoomStatus = @roomstatus; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@roomstatus", "Available");
                    cmd.Parameters.Add(param[0]);
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;
                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();
                        arr[3] = dataReader.GetValue(3).ToString();
                        if (arr[3] == temp)
                        {
                            arr[3] = "";
                        }
                        else
                        {
                            string temp2 = arr[3];
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
                            arr[3] = final;
                        }
                        arr[4] = dataReader.GetValue(4).ToString();
                        if (arr[4] == temp)
                        {
                            arr[4] = "";
                        }
                        else
                        {
                            string temp2 = arr[4];
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
                            arr[4] = final;
                        }
                        arr[5] = dataReader.GetValue(5).ToString();
                        arr[6] = dataReader.GetValue(6).ToString();

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

            if (radioButtonBooked.Checked)
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

                    sql = @"Select  RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost FROM Rooms WHERE RoomStatus = @roomstatus; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@roomstatus", "Booked");
                    cmd.Parameters.Add(param[0]);
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;
                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();
                        arr[3] = dataReader.GetValue(3).ToString();
                        if (arr[3] == temp)
                        {
                            arr[3] = "";
                        }
                        else
                        {
                            string temp2 = arr[3];
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
                            arr[3] = final;
                        }
                        arr[4] = dataReader.GetValue(4).ToString();
                        if (arr[4] == temp)
                        {
                            arr[4] = "";
                        }
                        else
                        {
                            string temp2 = arr[4];
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
                            arr[4] = final;
                        }
                        arr[5] = dataReader.GetValue(5).ToString();
                        arr[6] = dataReader.GetValue(6).ToString();

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

            if(radioButtonAvailable.Checked && comboBoxRoomTypeFilter.Text != "")
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

                    sql = @"Select  RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost FROM Rooms WHERE RoomStatus = @roomstatus AND RoomType = @roomtype; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[2];

                    param[0] = new SqlParameter("@roomstatus", "Available");
                    param[1] = new SqlParameter("@roomtype", comboBoxRoomTypeFilter.Text);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;
                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();
                        arr[3] = dataReader.GetValue(3).ToString();
                        if (arr[3] == temp)
                        {
                            arr[3] = "";
                        }
                        else
                        {
                            string temp2 = arr[3];
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
                            arr[3] = final;
                        }
                        arr[4] = dataReader.GetValue(4).ToString();
                        if (arr[4] == temp)
                        {
                            arr[4] = "";
                        }
                        else
                        {
                            string temp2 = arr[4];
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
                            arr[4] = final;
                        }
                        arr[5] = dataReader.GetValue(5).ToString();
                        arr[6] = dataReader.GetValue(6).ToString();

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

            if (radioButtonBooked.Checked && comboBoxRoomTypeFilter.Text != "")
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

                    sql = @"Select  RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost FROM Rooms WHERE RoomStatus = @roomstatus AND RoomType = @roomtype; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[2];

                    param[0] = new SqlParameter("@roomstatus", "Booked");
                    param[1] = new SqlParameter("@roomtype", comboBoxRoomTypeFilter.Text);
                    cmd.Parameters.Add(param[0]);
                    cmd.Parameters.Add(param[1]);
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;
                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();
                        arr[3] = dataReader.GetValue(3).ToString();
                        if (arr[3] == temp)
                        {
                            arr[3] = "";
                        }
                        else
                        {
                            string temp2 = arr[3];
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
                            arr[3] = final;
                        }
                        arr[4] = dataReader.GetValue(4).ToString();
                        if (arr[4] == temp)
                        {
                            arr[4] = "";
                        }
                        else
                        {
                            string temp2 = arr[4];
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
                            arr[4] = final;
                        }
                        arr[5] = dataReader.GetValue(5).ToString();
                        arr[6] = dataReader.GetValue(6).ToString();

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

            if(textBoxRoomNumFilter.Texts != "")
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

                    sql = @"Select  RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost FROM Rooms WHERE RoomNumber = @roomnumber; ";

                    cmd = new SqlCommand(sql, con);
                    SqlParameter[] param = new SqlParameter[1];

                    param[0] = new SqlParameter("@roomnumber", textBoxRoomNumFilter.Texts);
                    cmd.Parameters.Add(param[0]);                   
                    dataReader = cmd.ExecuteReader();
                    string temp = "01.1.1900 00:00:00";
                    while (dataReader.Read())
                    {
                        string[] arr = new string[7];
                        ListViewItem itm;
                        arr[0] = dataReader.GetValue(0).ToString();
                        arr[1] = dataReader.GetValue(1).ToString();
                        arr[2] = dataReader.GetValue(2).ToString();
                        arr[3] = dataReader.GetValue(3).ToString();
                        if (arr[3] == temp)
                        {
                            arr[3] = "";
                        }
                        else
                        {
                            string temp2 = arr[3];
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
                            arr[3] = final;
                        }
                        arr[4] = dataReader.GetValue(4).ToString();
                        if (arr[4] == temp)
                        {
                            arr[4] = "";
                        }
                        else
                        {
                            string temp2 = arr[4];
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
                            arr[4] = final;
                        }
                        arr[5] = dataReader.GetValue(5).ToString();
                        arr[6] = dataReader.GetValue(6).ToString();

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

                sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('Guests')";
                cmd = new SqlCommand(sql, con);
                int newProdID = (Int32)cmd.ExecuteScalar();
                if ((Int32)cmd.ExecuteScalar() == 0)
                {
                    sql = "CREATE TABLE Guests" + "(RoomNumber CHAR(255), Name CHAR(255), Surname CHAR(255), Age CHAR(255), EMBG CHAR(255), PhoneNumber CHAR(255), Mail CHAR(255), BookedFrom DATE, BookedTo DATE, Duration INT, TotalCost INT)";
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

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if(textBoxName.Texts == "" || textBoxSurname.Texts == "" || textBoxAge.Texts == "" || textBoxEMBG.Texts == "" || textBoxPhoneNumber.Texts == "" || textBoxMail.Texts == "" || textBoxRoomNumber.Texts == "" || textBoxDuration.Texts == "" || dateTimePickerFrom.Text == "" || dateTimePickerTo.Text == "" || comboBoxRoomType.Text == "")
            {
                MessageBox.Show("Missing Information!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    CreateTable();
                    dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
                    dateTimePickerFrom.CustomFormat = "yyyy-MM-dd";
                    string date = dateTimePickerFrom.Text;                 
                    SqlConnection con;
                    SqlCommand cmd;
                    SqlDataReader dataReader;
                    string sql;
                    con = new SqlConnection(connectionString);
                    con.Open();
                    sql = @"SELECT count(*) FROM Guests WHERE RoomNumber = @roomnumber and '" + date + "' between BookedFrom and BookedTo";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                    int num = (int)cmd.ExecuteScalar();
                    if (num == 0)
                    {
                        dateTimePickerTo.Format = DateTimePickerFormat.Custom;
                        dateTimePickerTo.CustomFormat = "yyyy-MM-dd";
                        string date2 = dateTimePickerTo.Text;
                        sql = @"SELECT count(*) FROM Guests WHERE RoomNumber = @roomnumber and '" + date2 + "' between BookedFrom and BookedTo";
                        cmd = new SqlCommand(sql, con);
                        cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                        int num2 = (int)cmd.ExecuteScalar();
                        if(num2 == 0)
                        {
                            sql = @"INSERT INTO Guests(RoomNumber, Name, Surname, Age, EMBG, PhoneNumber, Mail, BookedFrom, BookedTo, Duration, TotalCost) VALUES (@roomnumber, @name, @surname, @age, @embg, @phonenumber, @mail, @bookedfrom, @bookedto, @duration, @totalcost)";
                            cmd = new SqlCommand(sql, con);

                            string bookedfrom = dateTimePickerFrom.Value.ToString("yyyy-MM-dd");
                            string bookedto = dateTimePickerTo.Value.ToString("yyyy-MM-dd");
                            int totalcost = Convert.ToInt32(textBoxDuration.Texts) * Convert.ToInt32(textBoxRoomCost.Texts);

                            cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.AddWithValue("@name", textBoxName.Texts);
                            cmd.Parameters.AddWithValue("@surname", textBoxSurname.Texts);
                            cmd.Parameters.AddWithValue("@age", textBoxAge.Texts);
                            cmd.Parameters.AddWithValue("@embg", textBoxEMBG.Texts);
                            cmd.Parameters.AddWithValue("@phonenumber", textBoxPhoneNumber.Texts);
                            cmd.Parameters.AddWithValue("@mail", textBoxMail.Texts);
                            cmd.Parameters.AddWithValue("@bookedfrom", bookedfrom);
                            cmd.Parameters.AddWithValue("@bookedto", bookedto);
                            cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(textBoxDuration.Texts));
                            cmd.Parameters.AddWithValue("@totalcost", totalcost);
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //-----------------------------------------------------------------------------
                            //Find the closest date booked

                            con.Open();
                            sql = @"SELECT MIN(BookedFrom) from Guests WHERE RoomNumber = @roomnumber;";
                            cmd = new SqlCommand(sql, con);
                            SqlParameter[] param = new SqlParameter[1];
                            string min = "";
                            param[0] = new SqlParameter("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.Add(param[0]);
                            dataReader = cmd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                min = dataReader.GetValue(0).ToString();
                            }
                            dataReader.Close();

                            sql = "UPDATE Rooms SET BookedFrom = @bookedfrom Where RoomNumber = @roomnumber";
                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.AddWithValue("@bookedfrom", DateTime.Parse(min));
                            cmd.ExecuteNonQuery();

                            //-----------------------------------------------------------------------------
                            //Find the furthest date booked

                            sql = @"SELECT MAX(BookedTo) from Guests WHERE RoomNumber = @roomnumber;";
                            cmd = new SqlCommand(sql, con);
                            SqlParameter[] param2 = new SqlParameter[1];
                            string max = "";
                            param2[0] = new SqlParameter("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.Add(param2[0]);
                            dataReader = cmd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                max = dataReader.GetValue(0).ToString();
                            }
                            dataReader.Close();

                            sql = "UPDATE Rooms SET BookedTo = @bookedto Where RoomNumber = @roomnumber";
                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.AddWithValue("@bookedto", DateTime.Parse(max));
                            cmd.ExecuteNonQuery();

                            //------------------------------------------------------------------------------
                            //Sum up the days

                            sql = @"SELECT SUM(Duration) FROM Guests WHERE RoomNumber = @roomnumber;";
                            cmd = new SqlCommand(sql, con);
                            string duration = "";
                            SqlParameter[] param3 = new SqlParameter[1];
                            param3[0] = new SqlParameter("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.Add(param3[0]);
                            dataReader = cmd.ExecuteReader();
                            while (dataReader.Read())
                            {
                                duration = dataReader.GetValue(0).ToString();
                            }
                            dataReader.Close();

                            sql = "UPDATE Rooms SET Duration = @duration Where RoomNumber = @roomnumber";
                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.AddWithValue("@duration", Convert.ToInt32(duration));
                            cmd.ExecuteNonQuery();

                            //------------------------------------------------------------------------------
                            //Update the Room Status

                            sql = "UPDATE Rooms SET RoomStatus = @roomstatus Where RoomNumber = @roomnumber";
                            cmd = new SqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                            cmd.Parameters.AddWithValue("@roomstatus", "Booked");
                            cmd.ExecuteNonQuery();

                            con.Close();
                            SendMsg(textBoxMail.Texts, textBoxName.Texts + " " + textBoxSurname.Texts);
                            DeleteBooking();
                            textBoxName.Texts = "";
                            textBoxSurname.Texts = "";
                            textBoxAge.Texts = "";
                            textBoxEMBG.Texts = "";
                            textBoxMail.Texts = "";
                            textBoxPhoneNumber.Texts = "";
                            textBoxRoomCost.Texts = "";
                            textBoxDuration.Texts = "";
                            textBoxRoomNumber.Texts = "";
                            MessageBox.Show("Successful reservation!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("The room is already reserved for the selected date!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The room is already reserved for the selected date!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                            
                }
                catch
                {
                    MessageBox.Show("Email is not valid!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRoomProblem_Click(object sender, EventArgs e)
        {
            ReportProblem obj = new ReportProblem();
            obj.Show();       
        }

        private void buttonLoadBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (info.Length > 0)
                {
                    string[] subs = info.Split();
                    textBoxName.Texts = subs[0];
                    textBoxSurname.Texts = subs[1];
                    textBoxAge.Texts = subs[2];
                    textBoxEMBG.Texts = subs[3];
                    textBoxPhoneNumber.Texts = subs[4];
                    textBoxMail.Texts = subs[5];
                    comboBoxRoomType.Text = subs[6];
                    dateTimePickerFrom.Text = subs[7];
                    dateTimePickerTo.Text = subs[9];
                    info = "";
                }
            }
            catch
            {
                MessageBox.Show("You need to select a booking!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            sql = "Select RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost from Rooms";
            cmd = new SqlCommand(sql, con);
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                string[] arr = new string[7];
                ListViewItem itm;
                arr[0] = dataReader.GetValue(0).ToString();
                arr[1] = dataReader.GetValue(1).ToString();
                arr[2] = dataReader.GetValue(2).ToString();
                arr[3] = dataReader.GetValue(3).ToString();               
                if (arr[3] == temp)
                {
                    arr[3] = "";
                }   
                else
                {
                    string temp2 = arr[3];
                    string final = "";
                    for (int i = 0; i < temp2.Length;i++)
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
                    arr[3] = final;
                }
                arr[4] = dataReader.GetValue(4).ToString();
                if (arr[4] == temp)
                {
                    arr[4] = "";
                }
                else
                {
                    string temp2 = arr[4];
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
                    arr[4] = final;
                }
                arr[5] = dataReader.GetValue(5).ToString();
                arr[6] = dataReader.GetValue(6).ToString();

                itm = new ListViewItem(arr);
                listView1.Items.Add(itm);
            }
            dataReader.Close();
            con.Close();
        }

        public static void SendMsg(string email, string fullname)
        {

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            string hotelmail = "hotelmanagementsystem281203@gmail.com";
            string hotelpass = "cgqxngfmyssjtxpz";
            NetworkCredential NetworkCred = new NetworkCredential(hotelmail, hotelpass);
            smtp.Credentials = NetworkCred;

            MailMessage msg = new MailMessage();
            msg.Subject = "Hello " + fullname;
            msg.Body = "Hello " + fullname + ", thanks for making a reservation in the Hotel, we hope you have a pleasant stay!";
            msg.Body += "<tr>";     
            msg.Body += "</tr>";

            msg.Body += "<tr>";

            string toAddress = email;
            msg.To.Add(toAddress);

            string fromAddress = "\"Hotel Management System \" <hotelmanagementsystem281203@gmail.com>";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteBooking()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = @"DELETE FROM Bookings WHERE EMBG = @embg";
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@embg", textBoxEMBG.Texts);
                cmd.ExecuteNonQuery();

                con.Close();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
