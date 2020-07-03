using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(Path.GetDirectoryName(Application.StartupPath) + "\\other\\hello.gif");
        }

        private void lvl1_Click(object sender, EventArgs e)
        {
            Form1 l1 = new Form1();
            l1.Show();
        }

        private void lvl2_Click(object sender, EventArgs e)
        {
            Level2 l2 = new Level2();
            l2.Show();
        }

        private void lvl3_Click(object sender, EventArgs e)
        {
            Level3 l3 = new Level3();
            l3.Show();
        }
    }
}
