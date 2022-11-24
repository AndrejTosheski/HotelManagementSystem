using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace korisnichka_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Thread thread = new Thread(t =>
            {
                ThreadProc();
            })
            {
                IsBackground = true
            };
            thread.Start();
        }

        public void ThreadProc()
        {

            IPAddress ip = Dns.GetHostEntry("localhost").AddressList[0];
            TcpListener server = new TcpListener(ip, 8085);
            TcpClient client = default(TcpClient);
            try
            {
                server.Start();         
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            while (true)
            {
                client = server.AcceptTcpClient();
                byte[] receivedBuffer = new byte[1024];
                NetworkStream stream = client.GetStream();
                stream.Read(receivedBuffer, 0, receivedBuffer.Length);
                int count = Array.IndexOf<byte>(receivedBuffer, 0, 0);

                string msg = Encoding.ASCII.GetString(receivedBuffer, 0, count);
                byte[] sendData = Encoding.ASCII.GetBytes(msg);
                int b = sendData.Length;                            
            }
        }

        private void buttonReserve_Click(object sender, EventArgs e)
        {
            if (textBoxName.Texts == "" || textBoxSurname.Texts == "" || textBoxAge.Texts == "" || textBoxEMBG.Texts == "" || textBoxPhoneNumber.Texts == "" || textBoxMail.Texts == "" || comboBoxRoomType.Text == "")
            {
                MessageBox.Show("Missing infomation!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    string arrival = dateTimePickerArrival.Value.ToString("yyyy-MM-dd");
                    string departure = dateTimePickerDeparture.Value.ToString("yyyy-MM-dd");
                    TcpClient client = new TcpClient("localhost", 8080);

                    string str = textBoxName.Texts + " " + textBoxSurname.Texts + " " + textBoxAge.Texts + " " + textBoxEMBG.Texts + " " + textBoxPhoneNumber.Texts + " " + textBoxMail.Texts + " " + comboBoxRoomType.Text + " " + arrival + " " + departure;
                    int byteCount = Encoding.ASCII.GetByteCount(str);
                    byte[] sendData = Encoding.ASCII.GetBytes(str);

                    int broj = sendData.Length;
                    NetworkStream stream = client.GetStream();
                    stream.Write(sendData, 0, sendData.Length);

                    stream.Close();
                    client.Close();
                    MessageBox.Show("Reservation sent. You will recieve a confirmation email shortly!", "HMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxAge.Texts = "";
                    textBoxEMBG.Texts = "";
                    textBoxMail.Texts = "";
                    textBoxName.Texts = "";
                    textBoxPhoneNumber.Texts = "";
                    textBoxSurname.Texts = "";
                    comboBoxRoomType.Text = "";
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }    
        }
    }
}
