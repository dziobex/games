using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Pac_Man
{
    class Ghost : Game
    {
        Random randomizer = new Random();
        Point baseLocation = new Point(354, 456);
        Point target;
        public List<Label> Bounds { get; set; }
        public State CurrentState { get; private set; }
        public Label Block { get; set; }
        Player player;
        bool isPellet = false;
        Directions currentDir = Directions.Left;
        int speedX = 0, speedY = 0;

        Dictionary<Directions, int[]> capabilities = new Dictionary<Directions, int[]>
        {
            {Directions.Up, new int[]{ 0, 1 } },
            {Directions.Down, new int[]{ 2, 3 } },
            {Directions.Left, new int[]{ 0, 2 } },
            {Directions.Right, new int[]{ 1, 3 } }
        };

        public EnemyPB Representative { get; private set; }
        public Ghost(EnemyPB representative, Player player)
        {
            Bounds = new List<Label>();
            this.Representative = representative;
            this.player = player;
            speedX = -representative.Speed;
            target = player.Representative.Location;
            player.ActivatePellet += Player_ActivatePellet;
        }

        private void Player_ActivatePellet()
        {
            Representative.pelletCounter = 0;
            Representative.EatenPellet = true;
        }

        public void EatenPellet()
        {
            Representative.EatenPellet = isPellet;
        }

        public override void Teleport()
        {
            if (Representative.Location.X > 12 & Representative.Location.X < 694) return;
            if (Representative.Location.X < 12)
            {
                Representative.Location = new Point(694, Representative.Location.Y);
            }
            else if (Representative.Location.X > 694)
            {
                Representative.Location = new Point(12, Representative.Location.Y);
            }
        }

        void nextDirect()
        {
            // to avoid bugs ;]
            if (!canIMove(capabilities[Directions.Right], new Point(Representative.Location.X + 25, Representative.Location.Y))
                & !canIMove(capabilities[Directions.Up], new Point(Representative.Location.X, Representative.Location.Y - 25)))
                currentDir = generateAvailableArray(new Directions[] { Directions.Down, Directions.Left });
            else if (!canIMove(capabilities[Directions.Left], new Point(Representative.Location.X - 25, Representative.Location.Y))
                & !canIMove(capabilities[Directions.Up], new Point(Representative.Location.X, Representative.Location.Y - 25)))
                currentDir = generateAvailableArray(new Directions[] { Directions.Down, Directions.Right });
            else if (!canIMove(capabilities[Directions.Right], new Point(Representative.Location.X + 25, Representative.Location.Y))
                & !canIMove(capabilities[Directions.Down], new Point(Representative.Location.X, Representative.Location.Y + 25)))
                currentDir = generateAvailableArray(new Directions[] { Directions.Up, Directions.Left });
            else if (!canIMove(capabilities[Directions.Left], new Point(Representative.Location.X - 25, Representative.Location.Y))
                & !canIMove(capabilities[Directions.Down], new Point(Representative.Location.X, Representative.Location.Y + 25)))
                currentDir = generateAvailableArray(new Directions[] { Directions.Up, Directions.Right });
        }

        Directions generateAvailableArray(Directions[] myArray)
        {
            Directions[] ways = goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation);
            List<Directions> result = new List<Directions>();
            for (int i = 0; i < ways.Length; i++)
                foreach (Directions dir in myArray)
                    if (!result.Contains(dir) & ways.ToList().Contains(dir))
                        result.Add(dir);
            if (result.Count == 0) return myArray[randomizer.Next(myArray.Length)];
            return result[0];
        }

        int speed = 10;
        int speedXReturn = 10, speedYReturn = 10;
        public void ReturnToTheBase()
        {
            CurrentState = State.Eaten;
            // Representative.BackColor = Color.Red;
            Bounds.Remove(Block);
            Directions[] ways = goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation);
            Representative.Size = new Size(35, 27);
            Teleport();
            if (!correctDir()) { speedXReturn = -speedXReturn; speedYReturn = -speedYReturn; }
            nextDirect();
            Representative.Location = new Point(Representative.Location.X + speedXReturn, Representative.Location.Y + speedYReturn);
            if ((Representative.Location.X >= 455 & Representative.Location.X <= 466 & Representative.Location.Y >= 525 & Representative.Location.Y <= 548)
                | (Representative.Location.X >= 235 & Representative.Location.X <= 248 & Representative.Location.Y >= 521 & Representative.Location.Y <= 548))
                currentDir = Directions.Up;
            else if (canIMove(capabilities[currentDir], new Point(Representative.Location.X, Representative.Location.Y)))
            {
                if (canIMove(capabilities[Directions.Right], new Point(Representative.Location.X + 15, Representative.Location.Y))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation).ToList().Contains(Directions.Right)
                    & currentDir != Directions.Left)
                {
                    currentDir = Directions.Right;
                }
                else if (canIMove(capabilities[Directions.Left], new Point(Representative.Location.X - 15, Representative.Location.Y))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation).ToList().Contains(Directions.Left)
                    & currentDir != Directions.Right)
                {
                    currentDir = Directions.Left;
                }
                else if (canIMove(capabilities[Directions.Up], new Point(Representative.Location.X, Representative.Location.Y - 37))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation).ToList().Contains(Directions.Up)
                    & currentDir != Directions.Down)
                {
                    currentDir = Directions.Up;
                }
                else if (canIMove(capabilities[Directions.Down], new Point(Representative.Location.X, Representative.Location.Y + 37))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, baseLocation).ToList().Contains(Directions.Down)
                    & currentDir != Directions.Up)
                {
                    currentDir = Directions.Down;
                }
            }
            else
            {
                Representative.Location = new Point(Representative.Location.X - speedXReturn, Representative.Location.Y - speedYReturn);
                currentDir = randomDirection(ways, State.Eaten);
            }
            if (new Rectangle(Representative.Location, new Size(Representative.Width, Representative.Height)).Contains(baseLocation))
            {
                Representative.WasEaten = false;
                Representative.Act = false;
                Representative.GhostInBase = false;
                Representative.Size = new Size(37, 37);
            }
            setSpeed(false);
            Representative.SetEyes(currentDir);
        }

        public bool GhostOutside { get; private set; }
        public void Go()
        {
            Directions[] ways;
            CurrentState = State.Hunter;
            ways = goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target);
            Teleport();
            //else if (!correctDir()) { speedX = -speedX; speedY = -speedY; }
            target = player.Representative.Location;
            if (canIMove(capabilities[currentDir], Representative.Location))
            {
                Representative.Location = new Point(Representative.Location.X + speedX, Representative.Location.Y + speedY);
                if (canIMove(capabilities[Directions.Right], new Point(Representative.Location.X + 15, Representative.Location.Y))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target).ToList().Contains(Directions.Right)
                    & currentDir != Directions.Left)
                {
                    currentDir = Directions.Right;
                }
                else if (canIMove(capabilities[Directions.Left], new Point(Representative.Location.X - 15, Representative.Location.Y))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target).ToList().Contains(Directions.Left)
                    & currentDir != Directions.Right)
                {
                    currentDir = Directions.Left;
                }
                else if (canIMove(capabilities[Directions.Up], new Point(Representative.Location.X, Representative.Location.Y - 37))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target).ToList().Contains(Directions.Up)
                    & currentDir != Directions.Down)
                {
                    currentDir = Directions.Up;
                }
                else if (canIMove(capabilities[Directions.Down], new Point(Representative.Location.X, Representative.Location.Y + 37))
                    & goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target).ToList().Contains(Directions.Down)
                    & currentDir != Directions.Up)
                {
                    currentDir = Directions.Down;
                }
            }
            else
            {
                Representative.Location = new Point(Representative.Location.X - speedX, Representative.Location.Y - speedY);
                currentDir = randomDirection(goToPlayer(new Directions[] { Directions.Up, Directions.Down, Directions.Right, Directions.Left }, target), State.Hunter);
            }
            setSpeed(false);
            Representative.SetEyes(currentDir);
        }

        bool checkForCorrectDirection()
        {
            if (currentDir == Directions.Down & speedY < 0)
                return false;
            else if (currentDir == Directions.Up & speedY > 0)
                return false;
            else if (currentDir == Directions.Right & speedX < 0)
                return false;
            else if (currentDir == Directions.Left & speedX > 0)
                return false;
            return true;
        }

        bool correctDir()
        {
            if (currentDir == Directions.Down & speedYReturn < 0)
                return false;
            else if (currentDir == Directions.Up & speedYReturn > 0)
                return false;
            else if (currentDir == Directions.Right & speedXReturn < 0)
                return false;
            else if (currentDir == Directions.Left & speedXReturn > 0)
                return false;
            return true;
        }

        void setSpeed(bool returnToTheBase)
        {
            switch (currentDir)
            {
                case Directions.Up: speedX = 0; speedY = -Representative.Speed; break;
                case Directions.Down: speedX = 0; speedY = Representative.Speed; break;
                case Directions.Right: speedY = 0; speedX = Representative.Speed; break;
                case Directions.Left: speedX = -Representative.Speed; speedY = 0; break;
            }
            if (!checkForCorrectDirection())
            {
                speedX = -speedX;
                speedY = -speedY;
            }
            switch (currentDir)
            {
                case Directions.Up: speedXReturn = 0; speedYReturn = -speed; break;
                case Directions.Down: speedXReturn = 0; speedYReturn = speed; break;
                case Directions.Right: speedYReturn = 0; speedXReturn = speed; break;
                case Directions.Left: speedXReturn = speed; speedYReturn = 0; break;
            }
        }

        Directions[] goToPlayer(Directions[] dirs, Point t)
        {
            List<Directions> ways = new List<Directions>();
            if (t.X > Representative.Location.X)
                ways.Add(Directions.Right);
            else if (t.X < Representative.Location.X)
                ways.Add(Directions.Left);
            if (t.Y > Representative.Location.Y)
                ways.Add(Directions.Down);
            else if (t.Y < Representative.Location.Y)
                ways.Add(Directions.Up);
            return ways.ToArray();
        }
        Directions randomDirection(Directions[] dirs, State state)
        {
            double helper = 0.3;
            if (state == State.Eaten) helper = 0.4;
            Directions[] all = new Directions[] { Directions.Up, Directions.Down, Directions.Left, Directions.Right };
            Directions result = dirs[0];
            if (randomizer.NextDouble() >= helper & dirs.Length > 1) { do { result = dirs[randomizer.Next(dirs.Length)]; } while (currentDir == result); }
            else { do { result = all[randomizer.Next(all.Length)]; } while (currentDir == result); }
            return result;
        }

        bool canIMove(int[] ids, Point currentLoc)
        {
            foreach (Label b in Bounds)
            {
                Rectangle r = new Rectangle(b.Location, b.Size);
                List<Point> points = new Rectangle(currentLoc, Representative.Size).ExtremePoints().ToList();
                for (int i = 0; i < points.Count; i++)
                    if (r.Contains(points[i]))
                    {
                        return false;
                    }
            }
            return true;
        }
    }
}
