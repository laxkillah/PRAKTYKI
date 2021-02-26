using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Symulator_wyścigów
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RaceTrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;
        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(1, 6);
            Location = MyPictureBox.Left;

            if (Location >= RaceTrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            MyPictureBox.Left = 0;
        }


    }
}
