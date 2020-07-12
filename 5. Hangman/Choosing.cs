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
    public partial class Choosing : Form
    {
        Scores scores;
        public Choosing(Scores scores)
        {
            InitializeComponent();
            this.scores = scores;
            scores.SetNextRound();
            label1.Text = $"{scores.CurrentPlayer} chooses word!";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                pictureBox1.Image = Properties.Resources.Asset_181_512;
            }
            else
            {
                textBox2.PasswordChar = '*';
                pictureBox1.Image = Properties.Resources._lock;
            }
        }

        private void readyBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hangmann h = new Hangmann(textBox1.Text, textBox2.Text, scores);
            h.Closed += (s, args) => this.Close();
            h.Show();
        }

        private void text_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Focused)
                    textBox2.Focus();
                else if (textBox2.Focused & readyBtn.Enabled)
                    readyBtn_Click(this, new EventArgs());
            }
        }

        private void text_Changed(object sender, EventArgs e)
        {
            if (textBox1.Text.Any(c => Char.IsNumber(c) | Char.IsSymbol(c)
            | Char.IsPunctuation(c)))
            {
                errorProvider1.SetError(textBox1, "Category mustn't contain special chars.");
                readyBtn.Enabled = false;
            }
            else
                errorProvider1.SetError(textBox1, null);
            if (textBox2.Text.Any(c => Char.IsNumber(c) | Char.IsSymbol(c)
            | Char.IsPunctuation(c)))
            {
                errorProvider2.SetError(textBox2, "Password mustn't contain special chars.");
                readyBtn.Enabled = false;
            }
            else
                errorProvider2.SetError(textBox1, null);
            if (!textBox1.Text.Any(c => Char.IsNumber(c) | Char.IsSymbol(c)
            | Char.IsPunctuation(c)) & !textBox2.Text.Any(c => Char.IsNumber(c) | Char.IsSymbol(c)
            | Char.IsPunctuation(c))
                & textBox1.Text.Length > 2 & textBox2.Text.Length > 2)
                readyBtn.Enabled = true;
        }
    }
}
