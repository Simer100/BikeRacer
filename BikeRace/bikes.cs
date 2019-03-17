using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    class bikes
    {
        public string Name;
        public Bet place;
        public int amt;
        public int k;
        public RadioButton Rb_Button;
        public Label Labels;
      

        public void UpdateLabels()//this fuction is for thr update of the lable
        {
            Rb_Button.Text = Name + " has " + amt + " $";

            Labels.Text = Name+" hasn't not yet placed a bet";
            if (k == 1)
            {
                Labels.Text = Name + " hasn't not yet placed a bet";
            }
        }

        public bool Bet_palced(int amt_bet, int winerbike)//this fuction is for the placing of the bet 
        {
            place = new Bet() { bucks = amt_bet, bike = winerbike, Bettor = this };
            place.bucks = amt_bet;
            if (amt_bet > amt)
            {
                MessageBox.Show($@"you dont have enough money $");
                return false;
            }
            if (amt >= 1)
            {
                Labels.Text = place.lables_lb();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void RemoveBet()//this fuction is for the removing of bet
        {
            place.bucks = 0;
        }

        public void winer_bik(int Winner)
        {
            amt += place.winner_money(Winner);
            RemoveBet();
            UpdateLabels();
        }
    }
}
