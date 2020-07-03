using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pac_Man
{
    class Game
    {
        public int ExtraPoints = 0;
        public int Lives = 3;
        protected List<Food> availableFood;
        public List<Ghost> ghosts { get; protected set; }
        protected int score = 0;
        public int Score { get { return score; } }
        public Game()
        {
            availableFood = new List<Food>();
            ghosts = new List<Ghost>();
            prepareFoodForGame();
        }

        public void Start(Ghost g)
        {
            g.Representative.GhostInBase = false;
        }

        public virtual void Teleport() { }

        public void AddNewGhosts(List<Ghost> ghosts) => this.ghosts = ghosts;

        void prepareFoodForGame()
        {
            for (int i = 0; i < 7; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(85, 110), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[i-1].Location.X + 39, 110), new Size(21, 17), Properties.Resources.point));
            }
            for (int i=0; i<7; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(400, 110), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 110), new Size(21, 17), Properties.Resources.point));
            }
            for (int i=0; i<15; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(90, 841), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 841), new Size(21, 17), Properties.Resources.point));
            }
            for (int i=0; i<17; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(50, 213), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 213), new Size(21, 17), Properties.Resources.point));
            }
            for (int i=0; i<8; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(53, 610), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 610), new Size(21, 17), Properties.Resources.point));
            }
            for (int i = 0; i < 8; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(400, 610), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 610), new Size(21, 17), Properties.Resources.point));
            }
            int[] helper = new int[] { 50, 163, 322, 400, 555, 675 };
            for (int i=0; i<helper.Length; i++)
                for (int j=0; j<2; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 143), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X, availableFood[availableFood.Count - 1].Location.Y + 39), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 168, 555 };
            for (int i=0; i<helper.Length; i++)
            {
                for (int j=0; j<9; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 266), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X, availableFood[availableFood.Count - 1].Location.Y + 39), new Size(21, 17), Properties.Resources.point));
                }
            }
            for (int i=0; i<11; i++)
            {
                if (i == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(170, 695), new Size(21, 17), Properties.Resources.point));
                else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 695), new Size(21, 17), Properties.Resources.point));
            }
            for (int i=0; i<7; i++)
            {
                if (i == 0) { availableFood.Add(new Food(AvailableFood.PacDot, new Point(241, 375), new Size(21, 17), Properties.Resources.point));
                    availableFood.Add(new Food(AvailableFood.PacDot, new Point(241, 535), new Size(21, 17), Properties.Resources.point)); }
                else { availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count-2].Location.X + 39, 375), new Size(21, 17), Properties.Resources.point));
                    availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 2].Location.X + 39, 535), new Size(21, 17), Properties.Resources.point)); }
            }
            helper = new int[] { 53, 240, 397, 599 };
            for (int i=0; i<helper.Length; i++)
                for (int j=0; j<3; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 302), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 302), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 53, 555 };
            for (int i=0; i<helper.Length; i++)
                for (int j=0; j<4; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 769), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 769), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 53, 622 };
            for (int i=0; i<helper.Length; i++)
                for (int j=0; j<2; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 683), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 683), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 81, 594 };
            for (int i = 0; i < helper.Length; i++)
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 455), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X + 39, 455), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 251, 471 };
            for (int i=0; i<helper.Length; i++)
                for (int j=0; j<2; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 730), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X, availableFood[availableFood.Count - 1].Location.Y + 39), new Size(21, 17), Properties.Resources.point));
                }
            helper = new int[] { 314, 400 };
            for (int i = 0; i < helper.Length; i++)
                for (int j = 0; j < 2; j++)
                {
                    if (j == 0) availableFood.Add(new Food(AvailableFood.PacDot, new Point(helper[i], 765), new Size(21, 17), Properties.Resources.point));
                    else availableFood.Add(new Food(AvailableFood.PacDot, new Point(availableFood[availableFood.Count - 1].Location.X, availableFood[availableFood.Count - 1].Location.Y + 39), new Size(21, 17), Properties.Resources.point));
                }
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(53, 266), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(240, 266), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(471, 266), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(669, 266), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(314, 343), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(400, 343), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(209, 459), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(241, 419), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(511, 459), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(471, 419), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(241, 503), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(669, 644), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(471, 503), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(95, 735), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(241, 575), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(175, 735), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(471, 575), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(555, 735), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(175, 656), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(622, 724), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(314, 656), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(53, 803), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(400, 656), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(663, 803), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.PacDot, new Point(541, 656), new Size(21, 17), Properties.Resources.point)); availableFood.Add(new Food(AvailableFood.PacDot, new Point(56, 649), new Size(21, 17), Properties.Resources.point));
            availableFood.Add(new Food(AvailableFood.Pellet, new Point(47, 102), new Size(21, 17), Properties.Resources.pellet)); availableFood.Add(new Food(AvailableFood.Pellet, new Point(669, 102), new Size(21, 17), Properties.Resources.pellet));
            availableFood.Add(new Food(AvailableFood.Pellet, new Point(37, 447), new Size(21, 17), Properties.Resources.pellet)); availableFood.Add(new Food(AvailableFood.Pellet, new Point(250, 455), new Size(21, 17), Properties.Resources.pellet));
            availableFood.Add(new Food(AvailableFood.Pellet, new Point(471, 447), new Size(21, 17), Properties.Resources.pellet)); availableFood.Add(new Food(AvailableFood.Pellet, new Point(669, 447), new Size(21, 17), Properties.Resources.pellet));
            availableFood.Add(new Food(AvailableFood.Pellet, new Point(47, 833), new Size(21, 17), Properties.Resources.pellet)); availableFood.Add(new Food(AvailableFood.Pellet, new Point(663, 833), new Size(21, 17), Properties.Resources.pellet));
        }

        public virtual void DrawFood(Graphics g) { }
    }
}
