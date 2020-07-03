using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pac_Man
{
    static class NewMethod
    {
        public static Point[] ExtremePoints(this Rectangle r) => new Point[]
            {
                new Point(r.X, r.Y),
                new Point(r.X + r.Width/2, r.Y),
                new Point(r.X + r.Width, r.Y),
                new Point(r.X, r.Y + r.Height),
                new Point(r.X, r.Y + r.Height/2),
                new Point(r.X + r.Width/2, r.Y + r.Height),
                new Point(r.X + r.Width, r.Y + r.Height),
                new Point(r.X + r.Width, r.Y + r.Height/2),
            };
    }

    enum Directions
    {
        Up,
        Down,
        Right, 
        Left
    }

    enum AvailableFood
    {
        PacDot,
        Pellet
    }

    enum State
    {
        Hunter,
        Eaten,
        Frightened
    }
}
