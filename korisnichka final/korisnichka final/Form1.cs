using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korisnichka_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";
        private void btnRezervacija_Click(object sender, EventArgs e)
        {
            if (txtBoxIme.Text == "" || txtBoxPrezime.Text == "" || txtBoxKartichka.Text == "")
            {
                MessageBox.Show("Enter all infomation");
            }

            if (txtBoxKartichka.Text == "")
            {
                MessageBox.Show("vnesete validen broj od kartichka");
            }
        }
    }
}
