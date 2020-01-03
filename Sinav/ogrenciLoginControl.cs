using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Sinav
{
    public partial class ogrenciLoginControl : UserControl
    {
        public ogrenciLoginControl()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kullanıcı Girişi
            string username, password;
            Boolean onay;
            username = txtUsername.Text;
            password = txtPassword.Text;

            KullaniciGirisi kgiris = new KullaniciGirisi();

            onay = kgiris.ogrenciGiris(username, password);
            if (onay)
            {
                SqlCommand idgetir = new SqlCommand("Select id from tblKullanici where username='" + txtUsername.Text + "'", db.connectDataBase());
                SqlDataAdapter da = new SqlDataAdapter(idgetir);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Ogrenci.ogrid = Convert.ToInt32(dt.Rows[0]["id"]);
                formMain frm = new formMain();
                this.Hide();
                Login frmlgn = new Login();
                frmlgn.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Baglantı Hatası!!");
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
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
