using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitTheMolev2._0
{
    class Mole
    {
        public delegate void PopUp(int hole, bool show);
        public bool[] PointInCurrentRound = new bool[7] { true, true, true, true, true, true, true };
        PopUp popUpCallback;
        Random randomizer;
        bool hidden;

        public bool Hidden { get { return hidden; } }

        int timesShown = 0;
        int timesHit = 0;
        int hole = 0;
        List<int> holes;

        public int TimesHit { get { return timesHit; } }
        public int TimesShown { get { return timesShown; } set { timesShown = value; } }
        public int Hole { get { return hole; } }
        public int Holes { get { return holes.Count; } }

        public Mole(Random randomizer, PopUp popUpCallback)
        {
            this.randomizer = randomizer;
            this.popUpCallback = popUpCallback;
            hidden = true;
            holes = new List<int>();
        }

        public void Show()
        {
            if (!CheckForGameOver())
            {
                timesShown++;
                hidden = false;
                int num = randomizer.Next(7);
                hole = num;
                holes.Add(num);
                popUpCallback(hole, true);
            }
            else
            {
                Application.Exit();
                return;
            }
        }

        public void HideAgain()
        {
            PointInCurrentRound[holes[0]] = true;
            holes.RemoveAt(0);
            hidden = true;
            popUpCallback(hole, false);
        }

        bool addedPoint = false;
        public bool AddedPoint { get { return addedPoint; } }
        public void Smacked(int holeSmacked, bool uniqueChar)
        {
            for (int i = 0; i < holes.Count; i++)
            {
                if (holeSmacked == holes[i] & PointInCurrentRound[holes[i]])
                {
                    if (uniqueChar)
                        timesHit += 3;
                    else
                        timesHit++;
                    hidden = true;
                    if (CheckForGameOver())
                    {
                        Application.Exit();
                        return;
                    }
                    addedPoint = true;
                    PointInCurrentRound[holeSmacked] = true;
                    popUpCallback(hole, false);
                    holes.Clear();
                    return;
                }
            }
            addedPoint = false;
        }

        bool CheckForGameOver()
        {
            if (timesShown >= 10)
            {
                popUpCallback(-1, false);
                MessageBox.Show($"Points: {timesHit}/{timesShown}");
                return true;
            }
            return false;
        }
    }
}
