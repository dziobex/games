using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace Hangman
{
    class Gallows : PictureBox
    {
        public int ToDie { get; private set; }
        public Gallows()
        {
            base.DoubleBuffered = true;
            ToDie = 0;
        }

        public void IncreasePoints()
        {
            ToDie++;
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;
            Pen p = new Pen(Brushes.Black);
            if (ToDie >= 1)
                g.DrawLine(p, 30, Size.Height - 10, Size.Width / 2, Size.Height - 10);
            if (ToDie >= 2)
                g.DrawLine(p, (30 + Size.Width / 2)/2, Size.Height - 60, Size.Width / 2, Size.Height - 10);
            if (ToDie >= 3)
                g.DrawLine(p, (30 + Size.Width / 2) / 2, Size.Height - 60, 30, Size.Height - 10);
            if (ToDie >= 4)
                g.DrawLine(p, (30 + Size.Width / 2) / 2, Size.Height - 60, (30 + Size.Width / 2) / 2, 40);
            if (ToDie >= 5)
            {
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 40, (int)(Size.Width * 2 / 3), 60);
                g.DrawLine(p, (30 + Size.Width / 2) / 2, 40, (int)(Size.Width * 2 / 3), 40);
            }
            if (ToDie >= 6)
                g.DrawEllipse(p, new RectangleF(new Point((int)(Size.Width * 2)/3-15, 60), new SizeF(30, 30)));
            if (ToDie >= 7)
            {
                g.DrawLine(p, new Point((int)(Size.Width * 2) / 3 - 10, 70), new Point((int)(Size.Width * 2) / 3, 75));
                g.DrawLine(p, new Point((int)(Size.Width * 2) / 3, 70), new Point((int)(Size.Width * 2) / 3 - 10, 75));
            }
            if (ToDie >= 8)
            {
                g.DrawLine(p, new Point((int)(Size.Width * 2) / 3, 70), new Point((int)(Size.Width * 2) / 3 + 10, 75));
                g.DrawLine(p, new Point((int)(Size.Width * 2) / 3 + 10, 70), new Point((int)(Size.Width * 2) / 3, 75));
            }
            if (ToDie >= 9)
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 90, (int)(Size.Width * 2 / 3), 150);
            if (ToDie >= 10)
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 110, (int)(Size.Width * 2 / 3 + 20), 150);
            if (ToDie >= 11)
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 110, (int)(Size.Width * 2 / 3 - 20), 150);
            if (ToDie >= 12)
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 150, (int)(Size.Width * 2 / 3 + 20), 190);
            if (ToDie >= 13)
                g.DrawLine(p, (int)(Size.Width * 2 / 3), 150, (int)(Size.Width * 2 / 3 - 20), 190);
        }
    }
}
