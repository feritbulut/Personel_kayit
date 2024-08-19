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
using System.Diagnostics;

namespace Personel_Kayit
{
    public partial class Personelkayıt : Form
    {
        public Personelkayıt()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=LAPTOP-F5EB85PM\\SQLEXPRESS;Initial Catalog=personelVeriTabanı;Integrated Security=True");

        void temizle()
        {
            Perid.Text = "";
            Perad.Text = "";
            Persoyad.Text = "";
            sehir.Text = "";
            meslek.Text = "";
            Permaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            Perad.Focus();
        }

        private void Btnlistele_Click(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabanıDataSet1.Tbl_personel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_personelTableAdapter.Fill(this.personelVeriTabanıDataSet1.Tbl_personel);
        }

        private void Btnkaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_personel (PerAd,PerSoyad,PerSehir,Maas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", Perad.Text);
            komut.Parameters.AddWithValue("@p2", Persoyad.Text);
            komut.Parameters.AddWithValue("@p3", sehir.Text);
            komut.Parameters.AddWithValue("@p4", Permaas.Text);
            komut.Parameters.AddWithValue("@p5", meslek.Text);
            komut.Parameters.AddWithValue("@p6", label8.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label8.Text = "true";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "false";
            }
        }

        private void Btntemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            Perid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Perad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            Persoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            sehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Permaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
              radioButton2.Checked = true;
            }
        }

        private void Btnsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutsil = new SqlCommand("Delete from Tbl_personel where Personelid=@k1",baglanti);
            komutsil.Parameters.AddWithValue("@k1", Perid.Text);
            komutsil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
        }

        private void Btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komutguncelle = new SqlCommand("update Tbl_personel set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,Maas=@a4,PerDurum=@a5,PerMeslek=@a6 where Personelid=@a7", baglanti);
            komutguncelle.Parameters.AddWithValue("@a1", Perad.Text);
            komutguncelle.Parameters.AddWithValue("@a2", Persoyad.Text);
            komutguncelle.Parameters.AddWithValue("@a3", sehir.Text);
            komutguncelle.Parameters.AddWithValue("@a4", Permaas.Text);
            komutguncelle.Parameters.AddWithValue("@a5", label8.Text);
            komutguncelle.Parameters.AddWithValue("@a6", meslek.Text);
            komutguncelle.Parameters.AddWithValue("@a7", Perid.Text);
            komutguncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel bilgi güncellendi.");
        }

        private void Btnistatistik_Click(object sender, EventArgs e)
        {
            İstatistik ist = new İstatistik();
            ist.Show();

        }

        private void Btngrafikler_Click(object sender, EventArgs e)
        {
            Grafikler fr = new Grafikler();
            fr.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.linkedin.com/in/feritbulut/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://github.com/feritbulut",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.instagram.com/fertbult/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}
