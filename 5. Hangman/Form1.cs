using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        Scores scores;
        public Form1()
        {
            InitializeComponent();
        }

        private void text_Changed(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 3 | textBox2.Text.Length < 3)
                okBtn.Enabled = false;
            else
                okBtn.Enabled = true;
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter & textBox1.Focused)
                textBox2.Focus();
            else if (e.KeyCode == Keys.Enter & textBox2.Focused & okBtn.Enabled)
                okBtn_Click(this, new EventArgs());
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            scores = new Scores(textBox1.Text, textBox2.Text);
            this.Hide();
            Choosing mw = new Choosing(scores);
            mw.Closed += (s, args) => this.Close();
            mw.Show();
        }
    }
}
