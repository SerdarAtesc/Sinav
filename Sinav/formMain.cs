using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinav
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void btnFormMainClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void btnSinavaGir_Click(object sender, EventArgs e)
        {

            // Sınav Sorularını getir 

            SinavUserControl sinavUser = new SinavUserControl();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(sinavUser);

        }
            
            
            

        private void btnIstatislik_Click(object sender, EventArgs e)
        {
            //İstatislik hesaplanacak gösterilecek bu buton ile


        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SinavUserControl2 sinavuser2 = new SinavUserControl2();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(sinavuser2);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            SinavUserControl3 sinavuser3 = new SinavUserControl3();
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(sinavuser3);
        }
    }
}
