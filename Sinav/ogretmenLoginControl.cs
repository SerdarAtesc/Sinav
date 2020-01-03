using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav
{
    public partial class ogretmenLoginControl : UserControl
    {
        public ogretmenLoginControl()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kullanıcı Girişi
            string username, password;
            Boolean onay;
            username = txtUsername.Text;
            password = txtPassword.Text;

            KullaniciGirisi kgiris = new KullaniciGirisi();

            onay = kgiris.ogretmenGiris(username, password);
            if (onay)
            {
                formTeacher frm = new formTeacher();
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
