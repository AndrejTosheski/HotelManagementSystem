using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Runtime.InteropServices;

namespace Hotel_Management_System
{
    public partial class Main : Form
    {
        public static Thread thread;
        public static int brojac = 0;
        public Main(string user)
        {
            InitializeComponent();
            username = user;
            label3.Text = username;
            thread = new Thread(t =>
            {
                ThreadProc();
            })
            {
                IsBackground = true
            };
            if(brojac == 0)
            {
                thread.Start();
                brojac = 1;
            }                                 
        }

        public string username { get; set; }

        public void ThreadProc()
        {
            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8080);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            try
            {
                while (true)
                {
                    client = server.AcceptTcpClient();
                    byte[] receivedBuffer = new byte[1024];
                    NetworkStream stream = client.GetStream();
                    stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                    int count = Array.IndexOf<byte>(receivedBuffer, 0, 0);

                    string msg = Encoding.ASCII.GetString(receivedBuffer, 0, count);
                    if (msg.Length > 0)
                    {
                        TabBookings.BackColor = Color.Red;
                    }
                    panelBookings obj = new panelBookings(msg);
                }

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void TabRooms_Click(object sender, EventArgs e)
        {
            TabDashboard.BorderSize = 0;
            TabCheckout.BorderSize = 0;
            TabBookings.BorderSize = 0;
            TabGuests.BorderSize = 0;
            TabRooms.BorderSize = 3;        
            panelRooms panelRooms = new panelRooms();
            addUserControl(panelRooms);
        }

        private void TabGuests_Click(object sender, EventArgs e)
        {
            TabDashboard.BorderSize = 0;
            TabCheckout.BorderSize = 0;
            TabBookings.BorderSize = 0;
            TabRooms.BorderSize = 0;
            TabGuests.BorderSize = 3;
            panelGuests panelGuests = new panelGuests();
            addUserControl(panelGuests);
        }

        private void TabBookings_Click(object sender, EventArgs e)
        {
            TabBookings.BackColor = Color.FromArgb(52, 123, 152);
            TabDashboard.BorderSize = 0;
            TabCheckout.BorderSize = 0;
            TabGuests.BorderSize = 0;
            TabRooms.BorderSize = 0;
            TabBookings.BorderSize = 3;
            panelBookings panelBookings = new panelBookings();
            addUserControl(panelBookings);          
        }

        private void TabCheckout_Click(object sender, EventArgs e)
        {
            TabDashboard.BorderSize = 0;
            TabRooms.BorderSize = 0;
            TabBookings.BorderSize = 0;
            TabGuests.BorderSize = 0;
            TabCheckout.BorderSize = 3;
            panelCheckout panelCheckout = new panelCheckout();
            addUserControl(panelCheckout);
        }

        private void TabDashboard_Click(object sender, EventArgs e)
        {
            TabCheckout.BorderSize = 0;
            TabRooms.BorderSize = 0;
            TabBookings.BorderSize = 0;
            TabGuests.BorderSize = 0;
            TabDashboard.BorderSize = 3;
            panelDashboard panelDashboard = new panelDashboard();
            addUserControl(panelDashboard);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
