using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Snake
{
    [Serializable]
    class Highscores
    {
        public int Score { get; set; }
        string path = System.IO.Path.GetDirectoryName(Application.StartupPath) + "\\scores";
        public Dictionary<ListOfFood, int> statistics { get; private set; }
        public Highscores()
        {
            statistics = new Dictionary<ListOfFood, int>
            {
                { ListOfFood.apple, 0 },
                { ListOfFood.banana, 0 },
                { ListOfFood.cherry, 0 },
                { ListOfFood.peach, 0 },
                { ListOfFood.milk, 0 }
            };
        }

        public void IncreaseNumberOfShowing(ListOfFood food) { statistics[food]++; }

        public void SaveMyScore()
        {
            try
            {
                using (Stream saver = File.Create(path + "\\score" + Directory.GetFiles(path).Length.ToString() + ".snake"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(saver, this);
                }
            }
            catch { MessageBox.Show("I couldn't find folder width scores. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public int[] TheBestScores()
        {
            List<int> temp = new List<int>();
            List<int> result = new List<int>();
            try
            {
                for (int i = 0; i < Directory.GetFiles(path).Length; i++)
                {
                    Highscores hs;
                    using (Stream reader = File.OpenRead(path + "\\score" + i.ToString() + ".snake"))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        hs = (Highscores)bf.Deserialize(reader);
                    }
                    temp.Add(hs.Score);
                }
            }
            catch { MessageBox.Show("I couldn't find folder width scores. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            for (int i = 0; i < 3; i++)
            {
                if (temp.Count == 0)
                {
                    result.Add(0);
                    break;
                }
                result.Add(temp.Max());
                temp.Remove(temp.Max());
            }
            return result.ToArray();
        }
    }
}
