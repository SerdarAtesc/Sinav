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
    public partial class SinavUserControl : UserControl
    {
        DataBase db = new DataBase();
        string DogruCevap, Kategori, soruId;
        Boolean dogruMu;
        int sayac = 0, kayitSayisi, sayac2 = 0, sinavsayisi, msj = 0, msj2 = 0;
        public SinavUserControl()
        {


            InitializeComponent();
        }
        public void soruGetir()
        {
            SqlConnection con = db.connectDataBase();
            con.Open();
            SqlCommand sorgu = new SqlCommand("SELECT * FROM tblSoru", con);
            SqlCommand cmd = new SqlCommand("select count(*) from tblSoru", con);
            kayitSayisi = Convert.ToInt32(cmd.ExecuteScalar());
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dr = new DataTable();
            da.Fill(dr);


            if (sayac == 15)
            {
                con.Close();
                MessageBox.Show("SINAV BİTMİŞTİR..");
                this.Hide();

            }
            else
            {
                soruId = dr.Rows[sayac][0].ToString();
                lblSoru.Text = dr.Rows[sayac][1].ToString();
                btnA.Text = dr.Rows[sayac][2].ToString();
                btnB.Text = dr.Rows[sayac][3].ToString();
                btnC.Text = dr.Rows[sayac][4].ToString();
                btnD.Text = dr.Rows[sayac][5].ToString();
                DogruCevap = dr.Rows[sayac][6].ToString();
                Kategori = dr.Rows[sayac][7].ToString();
                picBoxResim.ImageLocation = dr.Rows[sayac][8].ToString();
                con.Close();
            }
        }
     
        
        public void sinavKagidi()
        {
            SqlCommand cmd;
            SqlConnection con = db.connectDataBase();

            string sorgu = "INSERT INTO tblSinav(UserId,SoruId,DogruMu,SoruKategorisi) VALUES (@userId,@soruId,@dogruMu,@soruKategorisi)";
            cmd = new SqlCommand(sorgu, con);

            cmd.Parameters.AddWithValue("@userId", Ogrenci.ogrid) ;
            cmd.Parameters.AddWithValue("@soruId", soruId);
            cmd.Parameters.AddWithValue("@dogruMu", dogruMu);
            cmd.Parameters.AddWithValue("@soruKategorisi", Kategori);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void SinavUserControl_Load(object sender, EventArgs e)
        {
            soruGetir();
            sayac++;


        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "A")
            {
                MessageBox.Show("A sikki dogru cevap bildin");
                dogruMu = true;
                
            }
            else
            {
                MessageBox.Show("Yanlış cevap!");
                dogruMu = false;
            }
            sinavKagidi();
            soruGetir();
            sayac++;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "B")
            {
                MessageBox.Show("B sikki dogru cevap bildin");
                dogruMu = true;

            }
            else
            {
                MessageBox.Show("Yanlış cevap!");
                dogruMu = false;
            }
            sinavKagidi();
            soruGetir();
            sayac++;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "C")
            {
                MessageBox.Show("C sikki dogru cevap bildin");
                dogruMu = true;

            }
            else
            {
                MessageBox.Show("Yanlış cevap!");
                dogruMu = false;
            }
            sinavKagidi();
            soruGetir();
            sayac++;


        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "D")
            {
                MessageBox.Show("D sikki dogru cevap bildin");
                dogruMu = true;

            }
            else
            {
                MessageBox.Show("Yanlış cevap!");
                dogruMu = false;
            }
            sinavKagidi();
            soruGetir();
            sayac++;
        }
        public void yanlisSorulariCek()
        {
            SqlConnection con = db.connectDataBase();
            SqlCommand sorgu = new SqlCommand("Select SoruID from tblsinav where UserId=" + Ogrenci.ogrid + "AND DogruMu=" + 0 + "", db.connectDataBase());
            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);

            con.Open();

            SqlCommand sorgu2 = new SqlCommand("SELECT * FROM tblSoru where id=" + Convert.ToInt32(dt.Rows[sayac2]["SoruId"]) + "", con);

            SqlDataAdapter da2 = new SqlDataAdapter(sorgu2);
            DataTable dr = new DataTable();
            da2.Fill(dr);


            if (dt.Rows.Count > sayac)
            {
                MessageBox.Show("Yanlış Bilinen Sorular Var");

                if (sayac2 == dt.Rows.Count)
                {
                    con.Close();
                    MessageBox.Show("SINAV BİTMİŞTİR..");
                    this.Hide();

                }
                else
                {

                    soruId = dr.Rows[sayac2][0].ToString();
                    lblSoru.Text = dr.Rows[sayac2][1].ToString();
                    btnA.Text = dr.Rows[sayac2][2].ToString();
                    btnB.Text = dr.Rows[sayac2][3].ToString();
                    btnC.Text = dr.Rows[sayac2][4].ToString();
                    btnD.Text = dr.Rows[sayac2][5].ToString();
                    DogruCevap = dr.Rows[sayac2][6].ToString();
                    Kategori = dr.Rows[sayac2][7].ToString();
                    picBoxResim.ImageLocation = dr.Rows[sayac2][8].ToString();
                    con.Close();
                    sayac2++;

                }

            }

        }


    }
}
