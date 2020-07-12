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
    public partial class Information : Form
    {
        public enum ToShow
        {
            winning,
            defeat
        }

        Scores scores;
        Image[] win, defeat;
        Random randomizer = new Random();

        public Information(ToShow toShow, string playerName, Scores scores)
        {
            InitializeComponent();
            this.scores = scores;
            win = new Image[]
            {
                Properties.Resources.congrat,
                Properties.Resources.win,
                Properties.Resources.giphy_1_1,
                Properties.Resources.gumball
            };
            defeat = new Image[]
            {
                Properties.Resources.at,
                Properties.Resources.youLose,
                Properties.Resources.defeat,
                Properties.Resources.defeat2,
                Properties.Resources.gameOver
            };
            if (toShow == ToShow.winning)
            {
                Text = "Winning!";
                pictureBox1.Image = win[randomizer.Next(win.Length)];
                label1.Text = $"Congratulations! {playerName} won!";
            }
            else
            {
                Text = "Defeat!";
                pictureBox1.Image = defeat[randomizer.Next(defeat.Length)];
                label1.Text = $"Unfortunately! {playerName} lost!";
            }
            label2.Text = $"* {scores.P1} has {scores.P1Score} points\n" +
                $"* {scores.P2} has {scores.P2Score} points";
            this.FormClosed += new FormClosedEventHandler(Information_Closed);
        }

        void Information_Closed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Choosing c = new Choosing(scores);
            c.Show();
        }
    }
}
