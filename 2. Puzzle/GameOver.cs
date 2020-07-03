using System;
using System.IO;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class GameOver : Form
    {
        Random randomizer;
        Highscores hs;

        public GameOver(int time, int mistakes, string lvl)
        {
            InitializeComponent();
            string path = Path.GetDirectoryName(Application.StartupPath);
            randomizer = new Random();
            string[] files = Directory.GetFiles(path + "\\congrat");
            pictureBox1.Load(files[randomizer.Next(0, files.Length)]);
            hs = new Highscores(path + "\\highscores\\" + lvl, mistakes, time);
            results.Text = String.Format($"You made {mistakes} mistakes.\nYou finished the board in {time} seconds.\nCongratulations!");
            hs.SaveScore();
            hs.OpenScores();
            highsc.Text = String.Format($"The best score (time) is {hs.Time} seconds.\nThe best score in the lowest value of mistakes: {hs.Mistakes}.");
        }
    }
}
