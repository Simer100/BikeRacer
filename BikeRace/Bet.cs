using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomLabelMove
{
    class Bet
    {
        public int bucks;
        public int bike;
        public bikes k;
        public bikes Bettor;
        public int winner_money(int winner)//this fuction is for the money after winning
        {
            if (bike == winner)
            {
                return bucks;
            }
            else
            {
                return -bucks;
            }
        }
        public string lables_lb()//this fuction is for the lable 
        {
            
            if (bucks > 0)
            {
                return Bettor.Name + " Bets " + bucks + " on " + "bike #" + bike;
            }
            
           
            else
            {

                return Bettor.Name + " hasn't noy yet placed a bet";
            }

        }
        
       
    }
}
