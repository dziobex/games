using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pac_Man
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void startLbl_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void startLbl_MouseHover(object sender, EventArgs e) => startLbl.Font = new Font(startLbl.Font, FontStyle.Underline);

        private void startLbl_MouseLeave(object sender, EventArgs e) => startLbl.Font = new Font(startLbl.Font, FontStyle.Regular);

        private void infoLbl_MouseHover(object sender, EventArgs e) => infoLbl.Font = new Font(infoLbl.Font, FontStyle.Underline);

        private void infoLbl_MouseLeave(object sender, EventArgs e) => infoLbl.Font = new Font(infoLbl.Font, FontStyle.Regular);

        private void infoLbl_Click(object sender, EventArgs e)
        {
            awsdPic.Visible = !awsdPic.Visible;
            useLbl.Visible = !useLbl.Visible;
        }
    }
}
