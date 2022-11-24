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
    public partial class panelDashboard : UserControl
    {
        public panelDashboard()
        {
            InitializeComponent();
            labelEmployees.Text = Employees();
            labelRooms.Text = Rooms();
            labelRoomsAvailable.Text = RoomsAvailable();
            labelRoomsBooked.Text = RoomsBooked();
            labelRoomsClosed.Text = RoomsClosed();
            labelGuests.Text = Guests();
            labelBookings.Text = Bookings();
            labelProfit.Text = TotalProfit();
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";

        public static string Employees()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Employee;";
                cmd = new SqlCommand(sql, con);
                int employees = (Int32)cmd.ExecuteScalar();  
                
                con.Close();     
                return employees.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }

        public static string Rooms()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Rooms;";
                cmd = new SqlCommand(sql, con);
                int rooms = (Int32)cmd.ExecuteScalar();

                con.Close();
                return rooms.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string RoomsAvailable()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Rooms WHERE RoomStatus = @roomstatus;";
                cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@roomstatus", "Available");
                cmd.Parameters.Add(param[0]);
                int available = (Int32)cmd.ExecuteScalar();

                con.Close();
                return available.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string RoomsBooked()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Rooms WHERE RoomStatus = @roomstatus;";
                cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@roomstatus", "Booked");
                cmd.Parameters.Add(param[0]);
                int booked = (Int32)cmd.ExecuteScalar();

                con.Close();
                return booked.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string RoomsClosed()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Rooms WHERE RoomStatus = @roomstatus;";
                cmd = new SqlCommand(sql, con);
                SqlParameter[] param = new SqlParameter[1];

                param[0] = new SqlParameter("@roomstatus", "Closed");
                cmd.Parameters.Add(param[0]);
                int closed = (Int32)cmd.ExecuteScalar();

                con.Close();
                return closed.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string Guests()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Guests;";
                cmd = new SqlCommand(sql, con);              
                int guests = (Int32)cmd.ExecuteScalar();

                con.Close();
                return guests.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string Bookings()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT COUNT(*) FROM Bookings;";
                cmd = new SqlCommand(sql, con);              
                int bookings = (Int32)cmd.ExecuteScalar();

                con.Close();
                return bookings.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
        public static string TotalProfit()
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT SUM(TotalCost) FROM Guests;";
                cmd = new SqlCommand(sql, con);               
                int total = (Int32)cmd.ExecuteScalar();

                con.Close();
                return total.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
                return 0.ToString();
            }
        }
    }
}
