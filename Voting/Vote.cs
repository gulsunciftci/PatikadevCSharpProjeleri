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
    public partial class Vote : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(localdb)/ProjectModels;Initial Catalog=Voting;Integrated Security=True"); 

        public Vote()
        {
            InitializeComponent();
        }

        private void voteB_Click(object sender, EventArgs e)
        {

        }
    }
}
