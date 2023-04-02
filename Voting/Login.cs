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
namespace Voting
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)/ProjectModels;Initial Catalog=Voting;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void registerR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register rf = new Register();
            rf.Show();
            this.Hide();
        }

        private void loginB_Click(object sender, EventArgs e)
        {
            if (fullName.Text.Length > 0 && emailT.Text.Length > 0)
            {
                Vote vf = new Vote();
                vf.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fullname and Email are required...");
            }
        }
    }
}
