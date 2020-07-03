using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pac_Man
{
    class Player : Game
    {
        public delegate void PelletWasEaten();
        public event PelletWasEaten ActivatePellet;
        public CharacterPB Representative { get; private set; }
        public Player(CharacterPB representative)
        {
            this.Representative = representative;
        }

        public void Move() { }

        public override void Teleport()
        {
            if (Representative.Location.X > 12 & Representative.Location.X < 694) return;
            if (Representative.Location.X < 12)
            {
                Representative.Location = new Point(694, Representative.Location.Y);
                Representative.Direction = Directions.Left;
            }
            else if (Representative.Location.X > 694)
            {
                Representative.Location = new Point(12, Representative.Location.Y);
                Representative.Direction = Directions.Right;
            }
        }

        public void Eat()
        {
            for (int i = base.availableFood.Count - 1; i >= 0; i--)
            {
                var result =
                    from p in new Rectangle(availableFood[i].Location, availableFood[i].Size).ExtremePoints()
                    where new Rectangle(Representative.Location, Representative.Size).Contains(p)
                    select p;
                if (result.Count() > 0)
                {
                    if (Representative.Visible)
                    {
                        if (availableFood[i].Name == AvailableFood.Pellet)
                            this.ActivatePellet();
                        score += base.availableFood[i].Points;
                        base.availableFood.RemoveAt(i);
                    }
                }
            }
        }

        public bool EatEnemy(Ghost ghost)
        {
            if (new Rectangle(Representative.Location, Representative.Size).IntersectsWith(new Rectangle(ghost.Representative.Location, ghost.Representative.Size)))
                return true;
            return false;
        }

        public override void DrawFood(Graphics g)
        {
            foreach (Food food in availableFood)
                g.DrawImage(food.Representative, food.Location);
        }
    }
}
