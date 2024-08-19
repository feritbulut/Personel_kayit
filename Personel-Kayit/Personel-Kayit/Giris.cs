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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-F5EB85PM\\SQLEXPRESS;Initial Catalog=personelVeriTabanı;Integrated Security=True");

        private void btngiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from Tbl_yonetici where Kulaniciad=@p1 and sifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", kullanıcıad.Text);
            komut.Parameters.AddWithValue("@p2", sifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Personelkayıt frm = new Personelkayıt();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı ya da şifre");
            }
            baglanti.Close();
        }
    }
}
