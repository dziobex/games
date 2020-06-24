using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Snake
{
    class Food
    {
        Size size;
        Image food;
        int maxHeight;
        int maxWidth;
        Random randomizer;
        Point location;
        Dictionary<ListOfFood, Image> imgs;
        public Point Location { get { return location; } }
        public int ValueOfFood { get; private set; }
        public ListOfFood CurrentFood { get; private set; }
        public Food(int maxHeight, int maxWidth, Random randomizer)
        {
            imgs = new Dictionary<ListOfFood, Image>
            {
                { ListOfFood.banana, Properties.Resources.banana },
                { ListOfFood.apple, Properties.Resources.apple },
                { ListOfFood.cherry, Properties.Resources.cherry },
                { ListOfFood.peach, Properties.Resources.peach }
            };
            this.maxHeight = maxHeight;
            this.maxWidth = maxWidth;
            this.randomizer = randomizer;
            location = new Point(randomizer.Next(50, maxWidth - 50), randomizer.Next(50, maxHeight - 50));
            GetRandomFood();
        }

        public void DrawFood(Graphics g, Brush b)
        {
            g.DrawImage(food, this.location);
            this.size = Properties.Resources.milk.Size;
        }

        public void GetRandomFood()
        {
            if (randomizer.NextDouble() >= 0.9)
            {
                food = Properties.Resources.milk;
                CurrentFood = ListOfFood.milk;
                ValueOfFood = 2;
            }
            else
            {
                var values = Enum.GetValues(typeof(ListOfFood));
                ListOfFood[] arrayFood = values as ListOfFood[];
                int randNum = randomizer.Next(arrayFood.Length-1);
                CurrentFood = arrayFood[randNum];
                food = imgs[CurrentFood];
                ValueOfFood = 1;
            }
        }

        public bool CollisionWithFood(List<Piece> snake)
        {
            Rectangle r2 = new Rectangle(this.Location, size);
            foreach (Piece piece in snake)
            {
                Rectangle r1 = new Rectangle(new Point(piece.X * 15, piece.Y * 15), new Size(15, 15));
                if (r1.Contains(r2.CenterOfRectangle())
                    | r2.Contains(r1.CenterOfRectangle())
                    | r1.ExtremeEdges().ToList().All(e => r2.Contains(e))
                    | r2.ExtremeEdges().ToList().All(e => r1.Contains(e)))
                    return true;
            }
            return false;
        }

        public void SetNewLocation() { location = new Point(randomizer.Next(50, maxWidth - 50), randomizer.Next(50, maxHeight - 50)); }
    }
}
