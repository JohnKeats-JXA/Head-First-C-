using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RUN_DOG
{
    class Greyhound
    {
        public int StartPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;  //在跑道上的位置
        public Random Randomizer;

        public bool Run()
        {
            if(MyPictureBox.Left + MyPictureBox.Width >= MyPictureBox.Parent.Width)
            {
                return true;
            }
            else
            {
                MyPictureBox.Left += Randomizer.Next(1, 4);
                return false;
            }
        }

        public void TakeStartPosition()
        {
            MyPictureBox.Left = StartPosition;
            Location = 0;
        }
    }
}
