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
    public partial class Hangmann : Form
    {
        Scores scores;
        List<char> found;
        string password;
        public Hangmann(string category, string password, Scores scores)
        {
            InitializeComponent();
            label1.Text = $"category: {category}";
            this.scores = scores;
            this.password = password;
            this.password = this.password.ToLower();
            found = new List<char>();
            updateState();
        }

        void updateState()
        {
            label2.Text = "";
            password.ToList().ForEach(c =>
            {
                if (!found.Contains(c)) label2.Text += "_ ";
                else label2.Text += $"{c} ";
            });
            label2.Text.Remove(password.Length - 1);
            if (found.Count == new String(password.ToCharArray().Distinct().ToArray()).Length)
            {
                foreach (var c in Controls)
                    if (c is Button)
                        (c as Button).Enabled = false;
                showInfo(Information.ToShow.winning);
            }
        }

        private void letter_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (!b.Enabled) return;
            else b.Enabled = false;
            if (!password.Contains(b.Text)) gallows1.IncreasePoints();
            else { found.Add(Convert.ToChar(b.Text)); updateState(); }
            if (gallows1.ToDie == 13)
            {
                foreach (var c in Controls)
                    if (c is Button)
                        (c as Button).Enabled = false;
                showInfo(Information.ToShow.defeat);
            }
        }

        void showInfo(Information.ToShow toShow)
        {
            string p = scores.CurrentPlayer;
            if (toShow == Information.ToShow.winning)
                scores.IncreasePoints(p, false);
            else
                scores.IncreasePoints(p, true);
            if (scores.CurrentPlayer == scores.P1) p = scores.P2;
            else p = scores.P1;
            this.Hide();
            Information information = new Information(toShow, p, scores);
            information.Show();
        }
    }
}
