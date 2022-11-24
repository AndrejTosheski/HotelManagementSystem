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
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        public struct Rooms
        {
            public string roomNumber;
            public string roomType;
            public string roomStatus;
            public string roomBookedFrom;
            public string roomBookedTo;
            public string roomDuration;
            public string roomCost;
        };

        public static void CreateTable()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('Rooms')";
                cmd = new SqlCommand(sql, con);
                int newProdID = (Int32)cmd.ExecuteScalar();
                if ((Int32)cmd.ExecuteScalar() == 0)
                {
                    sql = "CREATE TABLE Rooms" + "(RoomNumber CHAR(255) PRIMARY KEY, RoomType CHAR(255), RoomStatus CHAR(255), BookedFrom DATE, BookedTo DATE, Duration INT, RoomCost INT)";
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
        public static void InsertIntoTable(Rooms room)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = @"INSERT INTO Rooms(RoomNumber, RoomType, RoomStatus, BookedFrom, BookedTo, Duration, RoomCost) VALUES (@roomnumber, @roomtype, @roomstatus, @bookedfrom, @bookedto, @duration, @roomcost)";
                cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@roomnumber", room.roomNumber);
                cmd.Parameters.AddWithValue("@roomtype", room.roomType);
                cmd.Parameters.AddWithValue("@roomstatus", room.roomStatus);
                cmd.Parameters.AddWithValue("@bookedfrom", " ");
                cmd.Parameters.AddWithValue("@bookedto", " ");
                cmd.Parameters.AddWithValue("@duration", 0);
                cmd.Parameters.AddWithValue("@roomcost", Convert.ToInt32(room.roomCost));
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Room added!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);          
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumber.Texts == "" || comboBoxRoomType.Text == "" || textBoxRoomStatus.Texts == "" || textBoxRoomCost.Texts == "")
            {
                MessageBox.Show("Mising information!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    List<Rooms> listRooms = new List<Rooms>();

                    for (int i = 0; i < 1; i++)
                    {
                        Rooms room;
                        room.roomNumber = textBoxRoomNumber.Texts;
                        room.roomType = comboBoxRoomType.Text;
                        room.roomStatus = textBoxRoomStatus.Texts;
                        room.roomBookedFrom = "";
                        room.roomBookedTo = "";
                        room.roomDuration = "";
                        room.roomCost = textBoxRoomCost.Texts;
                        listRooms.Add(room);
                    }

                    CreateTable();

                    for (int i = 0; i < listRooms.Count; i++)
                    {
                        InsertIntoTable(listRooms[i]);
                    }
                    textBoxRoomNumber.Texts = "";
                    comboBoxRoomType.Text = "";                   
                    textBoxRoomCost.Texts = "";
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }
    }
}
