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
    public partial class formTeacher : Form
    {
        public formTeacher()
        {
            InitializeComponent();
        }

        private void btnSoruEkle_Click(object sender, EventArgs e)
        {
            teachersoruekle soruEkle = new teachersoruekle();

            pnlTeacherMain.Controls.Clear();
            pnlTeacherMain.Controls.Add(soruEkle);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }
    }
}
