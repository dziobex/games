using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Form1 : Form
    {
        List<MyPictureBox> myPictureBoxes;
        string[] listOfFiles;
        Random randomizer;
        Game game;
        public Form1()
        {
            InitializeComponent();
            randomizer = new Random();
            myPictureBoxes = new List<MyPictureBox>();
            listOfFiles = Directory.GetFiles(Path.GetDirectoryName(Application.StartupPath) + "\\lvl1", "*.jpg");
            game = new Game(new List<Button>() { n1, n2, n3, n4, n5, n6, n7, n8, n9 }, 9);
            prepareMyImages();
        }

        void prepareMyImages()
        {
            if (myPictureBoxes.Count != 0)
                foreach (MyPictureBox mpb in myPictureBoxes)
                    mpb.Hide();
            myPictureBoxes.Clear();
            for (int i = 0; i < 9; i++)
                myPictureBoxes.Add(new MyPictureBox(this.components, new MyPictureBox.GoToButton(ToButtonCallback)));
            int h = 0;
            for (int i = 0; i < 9; i++)
            {
                myPictureBoxes[i].Name = "n" + (i + 1).ToString();
                myPictureBoxes[i].Image = Image.FromFile(listOfFiles[h]);
                myPictureBoxes[i].Size = n1.Size;
                myPictureBoxes[i].SizeMode = PictureBoxSizeMode.Zoom;
                myPictureBoxes[i].Location = new Point(randomizer.Next(placeForPuzzles.Location.X, placeForPuzzles.Location.X + placeForPuzzles.Width-122),
                    randomizer.Next(placeForPuzzles.Location.Y, placeForPuzzles.Location.Y + placeForPuzzles.Height-122));
                this.Controls.Add(myPictureBoxes[i]);
                myPictureBoxes[i].BringToFront();
                h++;
            }
        }

        void ToButtonCallback(MyPictureBox mpb, bool move)
        {
            foreach(Control c in Controls)
                if (c.GetType() == typeof(Button))
                {
                    Rectangle r = new Rectangle(c.Location, c.Size);
                    if (r.Contains(mpb.Location) | r.Contains(new Point(mpb.Location.X+mpb.Width, mpb.Location.Y)))
                        if (move & !myPictureBoxes.Any(c1 => r.Contains(c1.Location) & c1 != mpb))
                        {
                            mpb.Location = r.Location;
                            game.CheckForMistake(mpb);
                            //MessageBox.Show($"{c.Name} and {mpb.Name}");
                        }
                }
        }

        private void startGameBtn_Click(object sender, EventArgs e)
        {
            foreach (MyPictureBox mpb in myPictureBoxes)
                mpb.Start = true;
            renewGameBtn.Visible = true;
            mainTimer.Start();
        }

        private void renewGameBtn_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            game.Mistakes = 0;
            startGameBtn.Visible = false;
            prepareMyImages();
            foreach (MyPictureBox mpb in myPictureBoxes)
                mpb.Start = true;
            time = -1;
            mainTimer.Start();
        }

        int time = 0;
        public int Time { get { return time; } }
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            time++;
            if (game.CheckAllBoard(myPictureBoxes))
            {
                mainTimer.Stop();
                Thread.Sleep(250);
                GameOver go = new GameOver(time, game.Mistakes, "lvl1");
                go.Show();
                this.Close();
            }
            timersText.Text = String.Format($"Time: {time} sec");
        }
    }
}
