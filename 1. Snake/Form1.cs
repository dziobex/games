using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        bool game = false;
        List<Piece> snakesBody = new List<Piece>();
        Food food;
        Snake snake;
        Highscores hs;
        Random randomizer = new Random();

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
            hs = new Highscores();
            food = new Food(field.Height, field.Width, randomizer);
            base.DoubleBuffered = true;
            snake = new Snake(field);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (game)
            {
                timer1.Stop();
                if (e.KeyCode == Keys.W & snake.Direction != Directions.Down) snake.Direction = Directions.Up;
                else if (e.KeyCode == Keys.S & snake.Direction != Directions.Up) snake.Direction = Directions.Down;
                if (e.KeyCode == Keys.A & snake.Direction != Directions.Right) snake.Direction = Directions.Left;
                else if (e.KeyCode == Keys.D & snake.Direction != Directions.Left) snake.Direction = Directions.Right;
                snake.Move();
                field.Invalidate();
                timer1.Start();
            }
        }

        private void field_Paint(object sender, PaintEventArgs e)
        {
            if (game)
            {
                Graphics g = e.Graphics;
                snake.DrawSnake(g);
                food.DrawFood(g, Brushes.Red);
                if (snake.CheckForGameOver())
                {
                    game = false;
                    timer1.Stop();
                    pauseToolStripMenuItem.Enabled = false;
                    GameOver();
                    return;
                }
                if (food.CollisionWithFood(snake.snakesBody))
                {
                    snake.AddNewPiece(food.ValueOfFood);
                    hs.Score = snake.snakesBody.Count;
                    hs.IncreaseNumberOfShowing(food.CurrentFood);
                    currentScoreLbl.Text = string.Format($"Current score: {hs.Score}");
                    food.GetRandomFood();
                    food.SetNewLocation();
                }
            }
        }

        private void nextMovements(object sender, EventArgs e)
        {
            snake.Move();
            field.Invalidate();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!game)
            {
                game = true;
                pauseToolStripMenuItem.Text = "Pause";
                timer1.Start();
            }
            else
            {
                game = false;
                pauseToolStripMenuItem.Text = "Continue game";
                timer1.Stop();
            }
        }

        private void renewGameToolStripMenuItem_Click(object sender, EventArgs e) => renewGame();
        private void startLabel_MouseEnter(object sender, EventArgs e) => startLbl.Font = new Font(startLbl.Font.Name, startLbl.Font.SizeInPoints, FontStyle.Underline);
        private void startLabel_MouseLeave(object sender, EventArgs e) => startLbl.Font = new Font(startLbl.Font.Name, startLbl.Font.SizeInPoints, FontStyle.Bold);

        void GameOver()
        {
            field.Invalidate();
            snakePic.Image = Properties.Resources.Snake_icon_dead;
            snakePic.Visible = true;
            startLbl.Location = new Point(95, 288);
            startLbl.Text = "Try again :]";
            startLbl.Visible = true;
            hs.SaveMyScore();
        }

        private void startLabel_Click(object sender, EventArgs e)
        {
            if (!statisticsToolStripMenuItem.Enabled)
            {
                Controls.Remove(awsdPic);
                Controls.Remove(awsdLbl);
                awsdPic.Dispose();
                awsdLbl.Dispose();
                statisticsToolStripMenuItem.Enabled = true;
                renewGameToolStripMenuItem.Enabled = true;
                helloLbl.Visible = false;
            }
            renewGame();
        }

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e) =>
            MessageBox.Show($"You have {hs.Score} score.\n— COLLECTED FOOD —\n*Apple: {hs.statistics[ListOfFood.apple]}\n*Banana: {hs.statistics[ListOfFood.banana]}" +
                $"\n*Cherry: {hs.statistics[ListOfFood.cherry]}\n*Peach: {hs.statistics[ListOfFood.peach]}\n*Milk: {hs.statistics[ListOfFood.milk]}", "Statistics");

        private void highscoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] scores = hs.TheBestScores();
            if (scores[0] <= 0)
                return;
            string result = "";
            byte helper = 0;
            foreach (int score in scores)
            {
                if (score != 0)
                    result += (helper+1).ToString() + ". " + score.ToString() + " score.\n";
                helper++;
            }
            MessageBox.Show(result, "Highscores:");
        }

        void renewGame()
        {
            snakePic.Visible = false;
            startLbl.Visible = false;
            game = true;
            pauseToolStripMenuItem.Enabled = true;
            game = true;
            food.GetRandomFood();
            food.SetNewLocation();
            snake = new Snake(field);
            pauseToolStripMenuItem.Text = "Pause";
            hs = new Highscores();
            currentScoreLbl.Text = string.Format($"Current score: {hs.Score}");
            timer1.Start();
        }
    }
}
