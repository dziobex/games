using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HitTheMolev2._0
{
    public partial class Form1 : Form
    {
        public static bool GameOver;

        Mole mole;
        List<MoleControl> moles;
        Random randomizer;
        public Form1()
        {
            InitializeComponent();
            randomizer = new Random();
            moles = new List<MoleControl> { moleControl1, moleControl2, moleControl3, moleControl4, moleControl5, moleControl6, moleControl7 };
            moleControl1.ID = 1; moleControl2.ID = 2; moleControl2.ID = 3; moleControl2.ID = 4; moleControl2.ID = 5; moleControl2.ID = 6; moleControl2.ID = 7;
            mole = new Mole(randomizer, new Mole.PopUp(MoleCallback));
            GameOver = false;
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            mainTimer.Stop();
            GameOver = moles.All(x => x.Hidden);
            ToggleMole();
        }

        void ToggleMole()
        {
            if (mole.Hidden)
            {
                int num = randomizer.Next(1, 3);
                for (int i = 0; i < num; i++)
                {
                    mole.Show();
                    timesShown.Text = string.Format($"Times shown: {mole.TimesShown}");
                }
            }
            else
                mole.HideAgain();
            mole.PointInCurrentRound[mole.Hole] = true;
            mainTimer.Start();
        }

        void MoleCallback(int hole, bool show)
        {
            if (hole < 0)
            {
                mainTimer.Stop();
                score.Text = $"Score: {mole.TimesHit}";
                return;
            }
            if (show)
            {
                int num = 60;
                if (mole.TimesShown < 10)
                    num = randomizer.Next(50, 90);
                moles[hole].NewTime = num;
                mainTimer.Interval = num * 14;
                mole.PointInCurrentRound[mole.Hole] = true;
                boomImg.Visible = false;
                if (moles[hole].UsedMole)
                    moles[hole].CurrentMole = true;
                else
                    mole.TimesShown = mole.TimesShown - mole.Holes;
                mainTimer.Start();
            }
        }

        private void mole_Smacked(object sender, EventArgs e)
        {
            MoleControl mc = sender as MoleControl;
            if (!mc.Hidden & !mc.Smacked)
            {
                boomImg.Location = new Point(mc.Location.X+mc.Width/2-boomImg.Width/3, mc.Location.Y+mc.Height/2-boomImg.Width/3);
                boomImg.Visible = true;
                mc.Smacked = true;
                mole.IncreasePoints(mc.UniqueChar);
            }
            else
                boomImg.Visible = false;
            score.Text = string.Format($"Score: {mole.TimesHit}");
        }
    }
}
