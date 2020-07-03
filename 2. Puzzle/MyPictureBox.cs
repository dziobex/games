using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace PuzzleGame
{
    class MyPictureBox : PictureBox
    {
        public delegate void GoToButton(MyPictureBox mpb, bool move);
        GoToButton tb;
        public bool Start { get; set; }

        Point p;
        public MyPictureBox(IContainer container, GoToButton tb)
        {
            container.Add(this);
            Start = false;
            this.tb = tb;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (Start)
            {
                p = e.Location;
                base.OnMouseDown(e);
                tb(this, false);
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (Start)
            {
                p = e.Location;
                base.OnMouseUp(e);
                tb(this, true);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Start)
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.Left += e.X - p.X;
                    this.Top += e.Y - p.Y;
                }
                base.OnMouseMove(e);
                tb(this, false);
            }
        }
    }
}
