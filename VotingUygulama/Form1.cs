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

namespace VotingUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        void griddoldur()
        {
            con = new SqlConnection("server=.; Initial Catalog=okul;Integrated Security=SSPI");
            da = new SqlDataAdapter("Select *From ogrenci", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "ogrenci");
            dataGridView1.DataSource = ds.Tables["ogrenci"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //DataTable Kategori = new DataTable("Kategori"); // 2
            //DataRow dt = Kategori.NewRow();
            //dt["KategoriName"] = "Film";
            //Kategori.Rows.Add(dt);
            //DataRow dt1 = Kategori.NewRow();
            //dt["KategoriName"] = "Tech Stack";
            //Kategori.Rows.Add(dt);
            //DataRow dt2 = Kategori.NewRow();
            //dt["KategoriName"] = "Spor";
            //Kategori.Rows.Add(dt);
            griddoldur();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "insert into ogrenci(ogrenci_no,ogrenci_ad,ogrenci_soyad,ogrenci_sehir) values (" + textBox1.Text + ",'"+ "')";
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }
    }
}
