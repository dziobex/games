using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PuzzleGame
{
    [Serializable]
    class Highscores
    {
        string path;
        public int Mistakes { get; private set; }
        public int Time { get; private set; }

        public Highscores(string path, int mistakes, int time)
        {
            this.path = path;
            this.Mistakes = mistakes;
            this.Time = time;
        }

        public void SaveScore()
        {
            int num = Directory.GetFiles(path, "*.hs").Length;
            using (Stream saver = File.Create(path + "\\score" + num.ToString() + ".hs"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(saver, this);
            }
        }

        public void OpenScores()
        {
            int maxTime = this.Time;
            int maxMistakes = this.Mistakes;
            int num = Directory.GetFiles(path, "*.hs").Length;
            if (num == 0)
                return;
            for (int i = 0; i < num; i++)
            {
                Highscores s;
                using (Stream reader = File.OpenRead(path + "\\score" + i.ToString() + ".hs"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    s = (Highscores)bf.Deserialize(reader);
                }
                if (maxTime > s.Time)
                {
                    maxTime = s.Time;
                    this.Time = s.Time;
                }
                if (maxMistakes > s.Mistakes)
                {
                    maxMistakes = s.Mistakes;
                    this.Mistakes = s.Mistakes;
                }
            }
        }
    }
}
