using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class racers
    {
        public PictureBox piture;
        public Random Randomizer;
        public int StartingPoint;


        public bool Move()//this function is for the moveing of the bike
        {
            piture.Left += Randomizer.Next(4);//this function gernates  a random number
            if(piture.Left >= piture.Parent.Width - piture.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Startbike()
        {
            piture.Left = StartingPoint;
        }
    }
}
