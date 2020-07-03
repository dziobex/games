using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Pac_Man
{
    class EnemyPB : PictureBox
    {
        public bool WasEaten = false;
        public bool ready = false;
        public int Speed { get { return speed; } }
        public bool EatenPellet = false;
        public bool Act = false;
        public bool GhostInBase = true;
        Label[] bounds;
        int speed;
        int motherSpeed;
        Timer timer, enemyMove;
        List<Bitmap> imgs, temp, eyes;
        Bitmap eye;
        Bitmap body;
        public Color Color { get; private set; }
        public Point Pos { get; set; }
        public EnemyPB(Color color, int speed, Label[] bounds)
        {
            this.motherSpeed = speed;
            this.Color = color;
            this.speed = speed;
            this.bounds = bounds;
            Pos = new Point(10, 10);
            base.DoubleBuffered = true;
            timer = new Timer();
            timer.Tick += new EventHandler(move);
            if (color == Color.Blue)
                imgs = new List<Bitmap>
                {
                    resize(Properties.Resources.blue0), resize(Properties.Resources.blue1)
                };
            else if (color == Color.Pink)
                imgs = new List<Bitmap>
                {
                    resize(Properties.Resources.pink0), resize(Properties.Resources.pink1)
                };
            else if (color == Color.Red)
                imgs = new List<Bitmap>
                {
                    resize(Properties.Resources.red0), resize(Properties.Resources.red1)
                };
            else if (color == Color.Yellow)
                imgs = new List<Bitmap>
                {
                    resize(Properties.Resources.yellow0), resize(Properties.Resources.yellow1)
                };
            temp = new List<Bitmap>(imgs);
            eyes = new List<Bitmap>
            {
                eyesResize(Properties.Resources.eyes0),
                eyesResize(Properties.Resources.eyes1),
                eyesResize(Properties.Resources.eyes2),
                eyesResize(Properties.Resources.eyes3)
            };
            body = imgs[0];
            timer.Interval = 80;
            eye = eyes[1];
            enemyMove = new Timer();
            enemyMove.Tick += new EventHandler(moving);
            enemyMove.Interval = 50;
            timer.Start();
        }

        public byte pelletCounter = 0;
        byte helper = 0;
        void move(object sender, EventArgs e)
        {
            if (EatenPellet)
            {
                imgs.CopyTo(temp.ToArray());
                imgs = new List<Bitmap>
                {
                    resize(Properties.Resources.pellet_ghost_0),
                    resize(Properties.Resources.pellet_ghost_1)
                };
                pelletCounter++;
                if (pelletCounter >= 25 & pelletCounter % 4 != 0)
                {
                    imgs = new List<Bitmap>
                    {
                        resize(Properties.Resources.white_pellet_0),
                        resize(Properties.Resources.white_pellet_1)
                    };
                }
            }
            else
            {
                imgs = temp.ToList();
            }
            body = imgs[helper];
            this.Invalidate();
            helper++;
            if (helper == imgs.Count)
                helper = 0;
            if (pelletCounter == 40)
            {
                EatenPellet = false;
                imgs = temp;
                pelletCounter = 0;
            }
            enemyMove.Start();
        }

        Point target = new Point(-1, -1);
        void moving(object sender, EventArgs e)
        {
            if (ready)
            {
                if (!Act)
                {
                    if (GhostInBase)
                    {
                        Random ranomizer = new Random();
                        Location = new Point(Location.X + speed, Location.Y);
                        if (Location.X + Width > bounds[1].Location.X)
                            speed = -speed;
                        else if (Location.X < bounds[0].Location.X + bounds[0].Width)
                            speed = Math.Abs(speed);
                    }
                    else if (!GhostInBase)
                    {
                        target = new Point(bounds[0].Location.X + bounds[0].Width + (bounds[1].Location.X - bounds[0].Location.X - bounds[0].Width) / 2 + 5, 362);
                        if (Location.X > target.X)
                            Location = new Point(Location.X - Math.Abs(speed), Location.Y);
                        else if (Location.X < target.X)
                            Location = new Point(Location.X + Math.Abs(speed), Location.Y);
                        if (Location.Y > target.Y)
                            Location = new Point(Location.X, Location.Y - Math.Abs(speed));
                        if (new Rectangle(Location, Size).Contains(target))
                            Act = true;
                    }
                }
            }
        }

        public void SetEyes(Directions dir)
        {
            if (dir == Directions.Right)
                eye = eyes[0];
            else if (dir == Directions.Down)
                eye = eyes[1];
            else if (dir == Directions.Left)
                eye = eyes[2];
            else
                eye = eyes[3];
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            if (!WasEaten)
            {
                g.DrawImage(body, 0, 0, body.Width, body.Height);
                SizeMode = PictureBoxSizeMode.Zoom;
                if (!EatenPellet)
                    g.DrawImage(eye, -1, -1, imgs[helper].Width, imgs[helper].Width);
            }
            else
                g.DrawImage(eye, -1, -1, imgs[helper].Width, imgs[helper].Width);
        }

        Bitmap resize(Bitmap bmp) => new Bitmap(bmp, 37, 37);
        Bitmap eyesResize(Bitmap bmp) => new Bitmap(bmp, 50, 50);
    }
}
