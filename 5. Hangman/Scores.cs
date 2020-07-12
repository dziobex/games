using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    public class Scores
    {
        public int P1Score;
        public int P2Score;
        public string P1 { get; private set; }
        public string P2 { get; private set; }
        public string CurrentPlayer { get; private set; }

        public Scores(string P1, string P2)
        {
            this.P1 = P1;
            this.P2 = P2;
            P1Score = 0;
            P2Score = 0;
            CurrentPlayer = "";
        }

        public void SetNextRound()
        {
            Random randomizer = new Random();
            if (CurrentPlayer == "")
                CurrentPlayer = new string[] { P1, P2 }[randomizer.Next(2)];
            else
            {
                if (CurrentPlayer == P1)
                    CurrentPlayer = P2;
                else
                    CurrentPlayer = P1;
            }
        }

        public void IncreasePoints(string player, bool winner)
        {
            if (winner & player == P1) P1Score++;
            else if (winner & player == P2) P2Score++;
            else if (!winner & player == P1) P2Score++;
            else if (!winner & player == P2) P1Score++;
        }
    }
}
