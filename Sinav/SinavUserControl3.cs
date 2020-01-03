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
    public partial class SinavUserControl3 : UserControl
    {
        string DogruCevap, Kategori, soruId;
        DataBase db = new DataBase();
        Boolean dogruMu;
        int sayac = 0, sayac2 = 0, sorusayaci = 0, yanlissorusayisi = 0;
        int[] idler = new int[15];
        SqlCommand sorgu;
        SqlDataAdapter da;
        DataTable dt;


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

        private void btnC_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "B")
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

        private void SinavUserControl3_Load(object sender, EventArgs e)
        {
            SqlConnection con = db.connectDataBase();

            SqlCommand sorgu = new SqlCommand("Select SoruID from tblsinav where UserId=" + Ogrenci.ogrid + "AND DogruMu=" + 0 + "", db.connectDataBase());


            SqlDataAdapter da = new SqlDataAdapter(sorgu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                idler[i] = Convert.ToInt32(dt.Rows[i]["soruId"]);
                yanlissorusayisi++;
            }




            soruGetir();
            sayac++;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "C")
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

        private void btnD_Click(object sender, EventArgs e)
        {
            if (DogruCevap == "D")
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


        public SinavUserControl3()
        {
            InitializeComponent();
        }
        public void soruGetir()
        {
            SqlConnection con = db.connectDataBase();


            con.Open();

            SqlCommand sorgu2 = new SqlCommand("SELECT * FROM tblSoru where id=" + idler[sorusayaci] + "", con);
            sorusayaci++;
            SqlDataAdapter da2 = new SqlDataAdapter(sorgu2);
            DataTable dr = new DataTable();
            da2.Fill(dr);


            if (yanlissorusayisi >= sayac2)
            {
                //   MessageBox.Show("Yanlış Bilinen Sorular Var");

                if (sayac2 == yanlissorusayisi)
                {
                    con.Close();
                    MessageBox.Show("SINAV BİTMİŞTİR..");
                    this.Hide();

                }
                else
                {


                    soruId = dr.Rows[0][0].ToString();
                    lblSoru.Text = dr.Rows[0][1].ToString();
                    btnA.Text = dr.Rows[0][2].ToString();
                    btnB.Text = dr.Rows[0][3].ToString();
                    btnC.Text = dr.Rows[0][4].ToString();
                    btnD.Text = dr.Rows[0][5].ToString();
                    DogruCevap = dr.Rows[0][6].ToString();
                    Kategori = dr.Rows[0][7].ToString();
                    picBoxResim.ImageLocation = dr.Rows[0][8].ToString();
                    con.Close();
                    sayac2++;

                }

            }
        }


        public void sinavKagidi()
        {
            SqlCommand cmd;
            SqlConnection con = db.connectDataBase();

            //  string sorgu = "INSERT INTO tblSinav(UserId,SoruId,DogruMu,SoruKategorisi) VALUES (@userId,@soruId,@dogruMu,@soruKategorisi)";
            string kayit = "UPDATE tblSinav set UserId=@userId,SoruId=@soruId,DogruMu=@dogruMu,SoruKategorisi=@soruKategorisi where soruId=" + soruId + "AND UserId=" + Ogrenci.ogrid + "";
            cmd = new SqlCommand(kayit, con);

            cmd.Parameters.AddWithValue("@userId", Ogrenci.ogrid);
            cmd.Parameters.AddWithValue("@soruId", soruId);
            cmd.Parameters.AddWithValue("@dogruMu", dogruMu);
            cmd.Parameters.AddWithValue("@soruKategorisi", Kategori);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();


        }





    }
}
