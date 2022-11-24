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
    public partial class ReportProblem : Form
    {
        public ReportProblem()
        {
            InitializeComponent();
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        private void buttonReport_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;              
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "UPDATE Rooms SET RoomStatus = @roomstatus Where RoomNumber = @roomnumber";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@roomnumber", textBoxRoomNumber.Texts);
                cmd.Parameters.AddWithValue("@roomstatus", comboBoxRoomStatus.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Room status has been changed!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
