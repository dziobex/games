using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PuzzleGame
{
    class Game
    {
        List<Button> buttons;
        int sizeOfBoard;
        public int Mistakes = 0;

        public Game(List<Button> buttons, int sizeOfBoard)
        {
            this.buttons = buttons;
            this.sizeOfBoard = sizeOfBoard;
        }

        public bool CheckEveryFieldInBoard(List<MyPictureBox> myPictureBoxes)
        {
            int helper = 0;
            foreach (Button b in buttons)
                foreach (MyPictureBox mpb in myPictureBoxes)
                    if (b.Location == mpb.Location)
                        helper++;
            if (helper == sizeOfBoard)
                return true;
            return false;
        }

        public bool CheckAllBoard(List<MyPictureBox> myPictureBoxes)
        {
            int helper = 0;
            for (int i=0; i<buttons.Count; i++)
                for (int j=i; j<myPictureBoxes.Count; j++)
                {
                    Rectangle r = new Rectangle(buttons[i].Location, buttons[i].Size);
                    if (r.Location == (myPictureBoxes[j].Location))
                    {
                        if (buttons[i].Name == myPictureBoxes[j].Name)
                            //MessageBox.Show($"{buttons[i].Name} and {myPictureBoxes[i].Name}");
                            helper++;
                        break;
                    }
                }
            if (helper == sizeOfBoard)
                return true;
            return false;
        }

        public void CheckForMistake(MyPictureBox mpb)
        {
            foreach (Button b in buttons)
                if (b.Location == mpb.Location & b.Name != mpb.Name)
                    Mistakes++;
        }
    }
}
