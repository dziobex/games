using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HitTheMolev2._0
{
    class MoleControl : PictureBox
    {
        bool currentMole = false;
        Timer timer;
        List<Bitmap> moleImages;
        List<Bitmap> unMoleImages;
        List<Bitmap> currentChar;
        Random randomizer = new Random();
        public MoleControl()
        {
            Image = Properties.Resources.empty_hole;
            timer = new Timer();
            timer.Tick += new EventHandler(timer_Tick);
            moleImages = new List<Bitmap>
            {
                Properties.Resources.diglett_1, Properties.Resources.diglett_2, Properties.Resources.diglett_3,
                Properties.Resources.diglett_4, Properties.Resources.diglett_5, Properties.Resources.diglett_6, Properties.Resources.diglett_7
            };
            unMoleImages = new List<Bitmap>
            {
                Properties.Resources.unique_diglett_1, Properties.Resources.unique_diglett_2, Properties.Resources.unique_diglett_3,
                Properties.Resources.unique_diglett_4, Properties.Resources.unique_diglett_5, Properties.Resources.unique_diglett_6, Properties.Resources.unique_diglett_7
            };
            Hidden = true;
            timer.Interval = 100;
            timer.Start();
        }

        public int ID;
        public bool CurrentMole { get { return currentMole; } set { currentMole = value; } }
        public bool UniqueChar { get { return uniqueChar; } }
        public int NewTime { set { timer.Interval = value; } }
        public bool UsedMole = true;
        public bool Hidden;
        public bool Smacked;

        int helper = 6, counter = 0;
        bool goBack = false;
        bool uniqueChar = false;
        void timer_Tick(object sender, EventArgs e)
        {
            if (currentMole)
            {
                if (goBack)
                {
                    helper = 6;
                    counter = 0;
                    Image = Properties.Resources.empty_hole;
                    currentMole = false;
                    goBack = false;
                }
                else
                {
                    if (counter == 0)
                    {
                        Smacked = false;
                        Hidden = false;
                        UsedMole = false;
                        if (randomizer.NextDouble() >= 0.9)
                        {
                            currentChar = unMoleImages;
                            uniqueChar = true;
                        }
                        else
                        {
                            currentChar = moleImages;
                            uniqueChar = false;
                        }
                    }
                    Image = currentChar[helper];
                    if (counter < 6)
                        helper--;
                    else if (counter > 6 & counter < 13)
                        helper++;
                    counter++;
                    if (counter == 13)
                    {
                        goBack = true;
                        UsedMole = true;
                        currentChar = null;
                        Hidden = true;
                        Smacked = false;
                    }
                }
            }
        }
    }
}
