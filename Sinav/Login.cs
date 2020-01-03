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
namespace Sinav
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataBase db = new DataBase();
       
   
        private void btnClose_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
       

       /* private void btnLogin_Click(object sender, EventArgs e)
        {
            //Kullanıcı Girişi
            string username, password;
            Boolean onay;
            username = txtUsername.Text;
            password = txtPassword.Text;

            KullaniciGirisi kgiris = new KullaniciGirisi();
           
            onay= kgiris.ogrenciGiris(username, password);
            if (onay)
            {
                formMain frm = new formMain();
                this.Hide();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Baglantı Hatası!!");
            }



        /*    SqlCommand cmd;
            SqlDataReader dr;
            db.connectDataBase();
            cmd = new SqlCommand();
            cmd.Connection = db.connectDataBase();
            cmd.Connection.Open();
            cmd.CommandText = "SELECT * FROM tblKullanici where username='" + txtUsername.Text + "' AND password='" + txtPassword.Text +  "'";
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                
                if (Convert.ToInt32( dr[3])==1)
                {
                    formMain frm = new formMain();
                    this.Hide();
                    frm.Show();

                }
                else 
                {

                    formTeacher frm = new formTeacher();
                    this.Hide();
                    frm.Show();
                }

               
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            

        }*/

       /* private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Login_Load(object sender, EventArgs e)
        {

        }*/

        private void btnTeacherlogin_Click(object sender, EventArgs e)
        {
            ogretmenLoginControl ogretmenLogin = new ogretmenLoginControl();
            pnlLogin.Controls.Clear();
            pnlLogin.Controls.Add(ogretmenLogin);
        }

        private void btnStudentLogin_Click(object sender, EventArgs e)
        {
            ogrenciLoginControl ogrenciLogin = new ogrenciLoginControl();
            pnlLogin.Controls.Clear();
            pnlLogin.Controls.Add(ogrenciLogin);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
           
            this.Close();
           
        }
    }
}
