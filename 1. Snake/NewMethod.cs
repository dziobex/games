using System.Drawing;

namespace Snake
{
    static class NewMethod
    {
        public static Point CenterOfRectangle(this Rectangle r)
        {
            return new Point(r.X + (r.Width / 2), r.Y + (r.Height / 2));
        }

        public static Point[] ExtremeEdges(this Rectangle r)
        {
            Point[] points = new Point[]
            {
                new Point(r.Location.X, r.Location.Y),
                new Point(r.Location.X + r.Width, r.Location.Y),
                new Point(r.Location.X, r.Location.Y + r.Height),
                new Point(r.Location.X + r.Width, r.Location.Y + r.Height)
            };
            return points;
        }
    }
}
