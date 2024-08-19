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

namespace Personel_Kayit
{
    public partial class İstatistik : Form
    {
        public İstatistik()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-F5EB85PM\\SQLEXPRESS;Initial Catalog=personelVeriTabanı;Integrated Security=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void İstatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbltoplam.Text = dr1[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_personel where PerDurum=1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {    
                evliper.Text = dr2[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select count(*) from Tbl_personel where PerDurum=0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                bekarper.Text = dr3[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select count(distinct(PerSehir)) from Tbl_personel", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                farklısehir.Text = dr4[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(Maas) from Tbl_personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                topmaas.Text = dr5[0].ToString();
            }
            baglanti.Close();
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select Avg(Maas) from Tbl_personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                ortmaas.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }
    }
}
