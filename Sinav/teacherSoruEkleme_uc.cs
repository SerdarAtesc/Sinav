using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sinav
{
    public partial class teachersoruekle : UserControl
    {
        public teachersoruekle()
        {
            InitializeComponent();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            kontrolEt();
        }
        void soruEkle()
        {
            DataBase db = new DataBase();
            SqlCommand cmd;
            SqlConnection con = db.connectDataBase();

            string sorgu = "INSERT INTO tblSoru(Soru,Asikki,Bsikki,Csikki,Dsikki,DogruCevap,Kategori,Resim) VALUES (@soru,@aSikki,@bSikki,@cSikki,@dSikki,@dogruCevap,@kategori@resim)";
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@soru", txtSoru.Text);
            cmd.Parameters.AddWithValue("@aSikki", txtAsikki.Text);
            cmd.Parameters.AddWithValue("@bSikki", txtBsikki.Text);
            cmd.Parameters.AddWithValue("@cSikki", txtCsikki.Text);
            cmd.Parameters.AddWithValue("@dSikki", txtDsikki.Text);
            cmd.Parameters.AddWithValue("@DogruCevap", cBoxDogru.Text);
            cmd.Parameters.AddWithValue("@kategori", cBoxCategory.Text);
            cmd.Parameters.AddWithValue("@resim", txtResim.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successful !");
            Temizleme();
        }
           

        void Temizleme()
        {
            txtAsikki.Text = "";
            txtBsikki.Text = "";
            txtCsikki.Text = "";
            txtDsikki.Text = "";
            txtSoru.Text = "";
            cBoxDogru.Text = "";
           cBoxCategory.Text = "";
        }
        void kontrolEt()
        {
            if (txtAsikki.Text == "" || txtBsikki.Text == "" || txtCsikki.Text == "" || txtDsikki.Text == "" || txtSoru.Text == "" || cBoxCategory.Text == "" || cBoxDogru.Text == "")
            {
                MessageBox.Show("Eksik veya Yanlış Deger Girdiniz!!");
            }
            else
            {
                soruEkle();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtResim.Text = openFileDialog1.FileName;
            picBoxResim.ImageLocation = openFileDialog1.FileName;
            
        }

        private void txtSoru_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar==8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtAsikki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtBsikki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCsikki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtDsikki_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
