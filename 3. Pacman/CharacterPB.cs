using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pac_Man
{
    class CharacterPB : PictureBox
    {
        public bool CanIMove = true;
        public bool IfDead = false;
        Timer timer;
        List<Bitmap> imgs, deadScene;
        public Directions Direction { get; set; }
        public CharacterPB()
        {
            timer = new Timer();
            timer.Tick += new EventHandler(move);
            timer.Interval = 80;
            imgs = new List<Bitmap>
            {
                Properties.Resources.pacman_test_0,
                Properties.Resources.pacman_test_1,
                Properties.Resources.pacman_test_2
            };
            deadScene = new List<Bitmap>
            {
                resize(Properties.Resources.dead_pacman_0),
                resize(Properties.Resources.dead_pacman_1),
                resize(Properties.Resources.dead_pacman_2),
                resize(Properties.Resources.dead_pacman_3),
                resize(Properties.Resources.dead_pacman_4),
                resize(Properties.Resources.dead_pacman_5),
                resize(Properties.Resources.dead_pacman_6),
                resize(Properties.Resources.dead_pacman_7),
                resize(Properties.Resources.dead_pacman_8),
                resize(Properties.Resources.dead_pacman_9)
            };
        }

        public void StartMoving() => timer.Start();

        byte helper = 0;
        void move(object sender, EventArgs e)
        {
            try
            {
                Image = imgs[helper];
                helper++;
            } catch { Image = imgs[0]; }
        }

        public void ChangeDirection()
        {
            if (!IfDead)
            {
                switch (Direction)
                {
                    case Directions.Right:
                        imgs = new List<Bitmap>
                    {
                    Properties.Resources.pacman_test_0,
                    Properties.Resources.pacman_test_1,
                    Properties.Resources.pacman_test_2
                    };
                        break;
                    case Directions.Left:
                        imgs = new List<Bitmap>
                    {
                    Properties.Resources.left_pac_0,
                    Properties.Resources.left_pac_1,
                    Properties.Resources.pacman_test_2
                    };
                        break;
                    case Directions.Down:
                        imgs = new List<Bitmap>
                    {
                    Properties.Resources.down_pac_0,
                    Properties.Resources.down_pac_1,
                    Properties.Resources.pacman_test_2
                    };
                        break;
                    case Directions.Up:
                        imgs = new List<Bitmap>
                    {
                    Properties.Resources.up_pac_0,
                    Properties.Resources.up_pac_1,
                    Properties.Resources.pacman_test_2
                    };
                        break;
                }
            }
            else
            {
                imgs = deadScene;
            }
        }

        public bool CallMe = false;
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (IfDead)
            {
                imgs = deadScene;
            }
            if (helper == imgs.Count & IfDead)
            {
                helper = Convert.ToByte(imgs.Count-1);
                timer.Stop();
            }
            else if (helper == imgs.Count)
                helper = 0;
            Graphics g = pe.Graphics;
            if (CanIMove | IfDead)
                g.DrawImage(imgs[helper], 0, 0);
            else
                g.DrawImage(imgs[1], 0, 0);
        }

        public void PrepareForStartPosition()
        {
            imgs = imgs = new List<Bitmap>
                    {
                    Properties.Resources.pacman_test_0,
                    Properties.Resources.pacman_test_1,
                    Properties.Resources.pacman_test_2
                    };
            helper = 0;
        }

        Bitmap resize(Bitmap bmp) => new Bitmap(bmp, 37, 37);
    }
}
