using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
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
    }
}
