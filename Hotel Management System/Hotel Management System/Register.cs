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
using System.Net.Mail;
using System.Net;
using System.Runtime.CompilerServices;

namespace Hotel_Management_System
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        public static string connectionString = "Server = DESKTOP-8S6LDCG\\SQLEXPRESS; Database= Hotel; Integrated Security=True;";

        public struct Licnost
        {
            public string id;
            public string name;
            public string surname;
            public string username;
            public string password;
            public string mail;
            public string phoneNumber;
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

                sql = "SELECT count(*) as IsExists FROM dbo.sysobjects where id = object_id('Employee')";
                cmd = new SqlCommand(sql, con);
                int newProdID = (Int32)cmd.ExecuteScalar();
                if ((Int32)cmd.ExecuteScalar() == 0)
                {
                    sql = "CREATE TABLE Employee" + "(Username CHAR(255) PRIMARY KEY,Name CHAR(255), Surname CHAR(255), Password CHAR(255), Id CHAR(255), Mail CHAR(255), PhoneNumber CHAR(255))";
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
        public static void InsertIntoTable(Licnost licnost)
        {
            try
            {
                SqlConnection con;
                SqlCommand cmd;
                string sql;
                con = new SqlConnection(connectionString);
                con.Open();

                sql = "SELECT count(*) FROM Employee WHERE Username = @username";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@username", licnost.username);
                int UserExist = (int)cmd.ExecuteScalar();

                if (UserExist == 0)
                {
                    string activationcode = GenerateCode();
                    List<string> list = new List<string>();
                    list.Add(licnost.username);
                    list.Add(licnost.name);
                    list.Add(licnost.surname);
                    list.Add(licnost.password);
                    list.Add(licnost.id);
                    list.Add(licnost.mail);
                    list.Add(licnost.phoneNumber);
                    SendMsg(licnost.mail, licnost.name += " " + licnost.surname, licnost.username, licnost.password, activationcode);                   
                    ConfirmCode obj = new ConfirmCode(activationcode, list);
                    obj.Show();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Username already exists!");                  
                    SqlDataReader dataReader;
                    List<string> listaiminja = new List<string>();
                    sql = @"Select  Username FROM Employee; ";
                    cmd = new SqlCommand(sql, con);                               

                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                         listaiminja.Add(dataReader.GetValue(0).ToString());
                        
                    }                                                        
                    string temp = licnost.username;
                    int brojac = 0;
                    
                    for (int i = 0; i < listaiminja.Count; i++)
                    {
                        bool tocen = false;
                        for (int j = 0; j < listaiminja.Count; j++)
                        {
                            if (temp == listaiminja[j].Trim())
                            {
                                tocen = true;
                                brojac++;
                                temp = licnost.username;
                                break;
                            }
                        }
                        if (tocen == true)
                        {
                            temp += brojac;
                        }
                    }
                    MessageBox.Show("You can use " + temp + " instead.");
                    dataReader.Close();
                    con.Close();
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }                     
        }
        
        private void buttonRegister_Click_1(object sender, EventArgs e)
        {          
            if (textBoxEMBG.Texts == "" || textBoxName.Texts == "" || textBoxSurname.Texts == "" || textBoxUsername.Texts == "" || textBoxPassword.Texts == "" || textBoxMail.Texts == "" || textBoxPhoneNumber.Texts == "")
            {
                MessageBox.Show("Mising information!");
            }
            else
            {
                if (textBoxPassword.Texts != textBoxConfirmPassword.Texts)
                {
                    MessageBox.Show("Password doesn't match!");
                }
                else
                {
                    try
                    {
                        List<Licnost> listLicnosti = new List<Licnost>();

                        for (int i = 0; i < 1; i++)
                        {
                            Licnost lic;
                            lic.id = textBoxEMBG.Texts;
                            lic.name = textBoxName.Texts;
                            lic.surname = textBoxSurname.Texts;
                            lic.username = textBoxUsername.Texts;
                            lic.password = textBoxPassword.Texts;
                            lic.mail = textBoxMail.Texts;
                            lic.phoneNumber = textBoxPhoneNumber.Texts;
                            listLicnosti.Add(lic);
                        }
                       
                        CreateTable();     
                        
                        for (int i = 0; i < listLicnosti.Count; i++)
                        {                         
                            InsertIntoTable(listLicnosti[i]);
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        public static String GenerateCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }

        public static void SendMsg(string email, string fullname, string username, string pass, string random)
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
            msg.Body = "Hello " + fullname + ", thanks for registering in the Hotel Management System, your account details are given below:";
            msg.Body += "<tr>";
            msg.Body += "<td>UserName: " + username + "</td>";
            msg.Body += "</tr>";
            msg.Body += "<tr>";
            msg.Body += "<td>Password: " + pass + "</td>";
            msg.Body += "</tr>";
            msg.Body += "<tr>";
            msg.Body += "<td>Activation Number: " + random + "</td>";
            msg.Body += "</tr>";

            msg.Body += "<tr>";          

            string toAddress = email;
            msg.To.Add(toAddress);

            string fromAddress = "\"Hotel Management System \" <hotelmanagementsystem@gmail.com>";
            msg.From = new MailAddress(fromAddress);
            msg.IsBodyHtml = true;

            try
            {
                smtp.Send(msg);
                MessageBox.Show("Email sent, please enter confirmation code.");
            }
            catch
            {
                throw;
            }
        }
    }
}
