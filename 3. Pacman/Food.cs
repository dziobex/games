using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pac_Man
{
    struct Food
    {
        public AvailableFood Name { get; private set; }
        public int Points { get; private set; }
        public Point Location { get; private set; }
        public Size Size { get; private set; }
        public Bitmap Representative { get; private set; }
        public Food(AvailableFood name, Point location, Size size, Bitmap representative)
        {
            this.Name = name;
            this.Location = location;
            this.Size = size;
            this.Representative = representative;
            switch (name)
            {
                case AvailableFood.PacDot: this.Points = 10; break;
                default: this.Points = 50; break;
            }
        }
    }
}
