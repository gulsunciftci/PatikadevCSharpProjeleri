using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Voting
{
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)/ProjectModels;Initial Catalog=Voting;Integrated Security=True");

        public Register()
        {
            InitializeComponent();
        }

        private void loginL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login lf = new Login();
            lf.Show();
            this.Hide();
        }

        private void registerB_Click(object sender, EventArgs e)
        {
            if (fullName.Text.Length > 0 && emailT.Text.Length>0)
            {
                try
                {
                    con.Open();

                    SqlCommand com = new SqlCommand("INSERT INTO Voter VALUES('"+fullName.Text+"','"+emailT.Text+"')",con);

                    try
                    {
                        com.ExecuteNonQuery();
                        MessageBox.Show("Success,you will be redirected to login page");
                        senEmail();
                        
                        Login lf = new Login();
                        lf.Show();
                        this.Hide();
                    
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed to Register");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to connect to Database");
                }
            }
            else
            {
                MessageBox.Show("Fullname and Email are required...");
            }
        }

        private void senEmail()
        {
            try
            {


                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("ciftcigulsun8@gmail.com");
                msg.To.Add(emailT.Text);
                msg.Subject = "Welcome to Vote Application";
                msg.Body = "Hello," + fullName.Text+"\n\nWelcome to Voting Application\n\nThank you";



                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new System.Net.NetworkCredential("myemail@gmail.com", "mypassword");
                ntcd.UserName = "ciftcigulsun8@gmail.com";
                ntcd.Password = "1234";
                smtp.Credentials = ntcd;
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(msg);

                MessageBox.Show("Check your  mail");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to send email");
            }
        }
    }
}
