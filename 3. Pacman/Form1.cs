using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pac_Man
{
    public partial class Form1 : Form
    {
        bool ready = false;
        List<EnemyPB> enemies;
        Game game;
        Player player;
        Directions direction = Directions.Down;
        Bitmap pic = new Bitmap(Properties.Resources.pacman_test_0);
        List<PictureBox> lives;
        public Form1()
        {
            InitializeComponent();
            base.DoubleBuffered = true;
            game = new Game();
            player = new Player(pacman);
            enemies = new List<EnemyPB>();
            prepareEnemies();
            game.AddNewGhosts(new List<Ghost>()
            {
                new Ghost(enemies[0], player),
                new Ghost(enemies[1], player),
                new Ghost(enemies[2], player),
                new Ghost(enemies[3], player),
            });
            lives = new List<PictureBox>() { pictureBox1, pictureBox2, pictureBox3 };
            pacman.StartMoving();
        }

        void prepareEnemies()
        {
            Label[] bounds = new Label[] { label53, label54 };
            enemies.Add(new EnemyPB(Color.Blue, 10, bounds) { Location = new Point(317, 433), Size = new Size(37, 37) });
            enemies.Add(new EnemyPB(Color.Red, 10, bounds) { Location = new Point(370, 433), Size = new Size(37, 37) });
            enemies.Add(new EnemyPB(Color.Yellow, 10, bounds) { Location = new Point(400, 433), Size = new Size(37, 37) });
            enemies.Add(new EnemyPB(Color.Pink, 11, bounds) { Location = new Point(340, 433), Size = new Size(37, 37) });
            foreach (EnemyPB epb in enemies)
                Controls.Add(epb);
        }

        bool start = true;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (ready & start)
            {
                if (e.KeyCode == Keys.W)
                {
                    direction = Directions.Up;
                    pacman.ChangeDirection();
                    pacman.Direction = direction;
                }
                else if (e.KeyCode == Keys.S)
                {
                    direction = Directions.Down;
                    pacman.ChangeDirection();
                    pacman.Direction = direction;
                }
                else if (e.KeyCode == Keys.D)
                {
                    direction = Directions.Right;
                    pacman.ChangeDirection();
                    pacman.Direction = direction;
                }
                else if (e.KeyCode == Keys.A)
                {
                    direction = Directions.Left;
                    pacman.ChangeDirection();
                    pacman.Direction = direction;
                }
                player.Eat();
                if (!start) start = true;
                base.Invalidate();
            }
        }

        bool canIMove(int[] ids, Point currentLoc)
        {
            foreach (Control c in Controls)
                if (c is Label & c.Name != label2.Name & c.Name != label1.Name)
                {
                    Rectangle r = new Rectangle(c.Location, c.Size);
                    List<Point> points = new Rectangle(currentLoc, pacman.Size).ExtremePoints().ToList();
                    for (int i = 0; i < points.Count; i++)
                        if (r.Contains(points[i]))
                            return false;
                }
            return true;
        }

        Font font = new Font("Arial", 16);

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point helper;
            if (start)
            {
                switch (pacman.Direction)
                {
                    case Directions.Up:
                        helper = new Point(pacman.Location.X, pacman.Location.Y - 10);
                        pacman.ChangeDirection();
                        if (canIMove(new int[] { 0, 1 }, helper))
                        {
                            pacman.Location = helper;
                            pacman.CanIMove = true;
                        }
                        else
                            pacman.CanIMove = false;
                        break;
                    case Directions.Down:
                        helper = new Point(pacman.Location.X, pacman.Location.Y + 10);
                        pacman.ChangeDirection();
                        if (canIMove(new int[] { 0, 1 }, helper))
                        {
                            pacman.Location = helper;
                            pacman.CanIMove = true;
                        }
                        else
                            pacman.CanIMove = false;
                        break;
                    case Directions.Left:
                        helper = new Point(pacman.Location.X - 10, pacman.Location.Y);
                        pacman.ChangeDirection();
                        if (canIMove(new int[] { 0, 1 }, helper))
                        {
                            pacman.Location = helper;
                            pacman.CanIMove = true;
                        }
                        else
                            pacman.CanIMove = false;
                        break;
                    case Directions.Right:
                        helper = new Point(pacman.Location.X + 10, pacman.Location.Y);
                        pacman.ChangeDirection();
                        if (canIMove(new int[] { 0, 1 }, helper))
                        {
                            pacman.Location = helper;
                            pacman.CanIMove = true;
                        }
                        else
                            pacman.CanIMove = false;
                        break;
                }
            }

            List<Label> bounds = new List<Label>();
            foreach (Control c in Controls)
                if (c is Label & c.Name != label2.Name & c.Name != label1.Name & c.Name != label58.Name)
                    bounds.Add(c as Label);
            if (start)
            {
                foreach (Ghost g in game.ghosts)
                {
                    if (!g.Representative.GhostInBase & !g.Representative.WasEaten)
                    {
                        g.Bounds = bounds;
                        g.Go();
                    }
                    else if (g.Representative.EatenPellet)
                        g.Go();
                    else if (g.Representative.WasEaten)
                        g.ReturnToTheBase();
                }
            }

            for (int i = game.ghosts.Count - 1; i >= 0; i--)
            {
                if (game.ghosts[i].Representative.EatenPellet & player.EatEnemy(game.ghosts[i]) & !game.ghosts[i].Representative.WasEaten)
                {
                    game.ghosts[i].Block = label57;
                    game.ghosts[i].Representative.WasEaten = true;
                    var tem =
                        from g in game.ghosts
                        where g.Representative.WasEaten
                        select g;
                    player.ExtraPoints += ((tem.Count()) * 200);
                    game.ghosts[i].ReturnToTheBase();
                }
                else if (player.EatEnemy(game.ghosts[i]) & game.ghosts[i].Representative.Visible & !game.ghosts[i].Representative.EatenPellet & game.ghosts[i].CurrentState == State.Hunter)
                {
                    ready = false;
                    start = false;
                    foreach (var v in game.ghosts)
                        v.Representative.Visible = false;
                    game.Lives--;
                    pacman.IfDead = true;
                    updateLives();
                    if (game.Lives == 0)
                    {
                        ready = false;
                        foreach (var g in game.ghosts)
                            g.Representative.Visible = false;
                        label1.Text = "Game over!";
                        label1.Visible = true;
                        ready = false;
                        timer1.Stop();
                        start = false;
                        for (int j = game.ghosts.Count - 1; j >= 0; j--)
                        {
                            game.ghosts[j].Representative.Visible = false;
                            game.ghosts[j].Representative.Dispose();
                        }
                        moving = false;
                        temporaryTimer.Enabled = prepareGhosts.Enabled = false;
                    }
                    if (lives.Count < 1)
                        start = false;
                    timerToNextGame.Start();
                }
            }
            if (game.ghosts.Any(g => g.Representative.GhostInBase))
            {
                temporaryTimer.Enabled = true;
            }
            player.Eat();
            player.Teleport();
            Invalidate();
        }

        void updateLives()
        {
            if (lives.Count == 0) return;
            int num = 0;
            if (game.Lives != 0)
                num = lives.Count - 1;
            lives[num].Visible = false;
            lives[num].Dispose();
            lives.RemoveAt(num);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scoreLbl.Text = $"Score: {player.Score + player.ExtraPoints}";
            if (player.Score >= 2190)
            {
                label1.Text = "You won!";
                label1.Visible = true;
                ready = false;
                moving = false;
                start = false;
            }
            player.DrawFood(e.Graphics);
        }

        byte help = 0;
        private void temporaryTimer_Tick(object sender, EventArgs e)
        {
            if (lives.Count < 1)
            {
                pacman.Location = new Point(352, 684);
                start = false;
                pacman.Visible = false;
            }
            if (label1.Visible)
            {
                start = true;
                label1.Visible = false;
                ready = true;
                foreach (Ghost g in game.ghosts)
                    if (g.Representative.GhostInBase)
                    {
                        g.Representative.ready = true;
                    }
            }
            if (help < 4)
                game.Start(game.ghosts[help]);
            else
            {
                help = 0;
                temporaryTimer.Stop();
                return;
            }
            if (!timer1.Enabled) timer1.Enabled = true;
            help++;
        }

        bool moving = true;

        Random randomizer = new Random();
        void nextGame()
        {
            label1.Visible = true;
            start = false;
            moving = false;
            ready = true;
            pacman.CanIMove = true;
            pacman.IfDead = false;
            pacman.Location = new Point(352, 684);
            pacman.PrepareForStartPosition();
            foreach (var g in game.ghosts)
            {
                g.Representative.Size = new Size(37, 37);
                g.Representative.Location = new Point(randomizer.Next(300, 390), 440);
                g.Representative.Visible = true;
                g.Representative.WasEaten = false;
                g.Representative.ready = true;
                g.Representative.EatenPellet = false;
                g.Representative.Act = false;
                g.Representative.GhostInBase = true;
            }
            Console.WriteLine($"{moving} and {player.Lives}");
            if (moving)
                start = true;
        }

        byte stuff = 0;
        private void timerToNextGame_Tick(object sender, EventArgs e)
        {
            if (stuff == game.ghosts.Count)
            {
                stuff = 0;
                timerToNextGame.Enabled = false;
            }
            prepareGhosts.Enabled = true;
        }

        private void prepareGhosts_Tick(object sender, EventArgs e)
        {
            if (lives.Count > 0) pacman.StartMoving();
            if (!ready) nextGame();
            temporaryTimer.Enabled = true;
        }
    }
}