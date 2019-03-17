using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLabelMove
{
    public partial class game : Form
    {
        bikes[] bike = new bikes[3];
        Bet bet = new Bet();
        racers[] race = new racers[4];
        Random random = new Random();
        public game()
        {
            InitializeComponent();
            bike[0] = new bikes() { Name = "gill", amt = 50, Rb_Button = radioButtongill, Labels = labelgill };
            bike[1] = new bikes() { Name = "summet", amt = 50, Rb_Button = radioButtonsum, Labels = labelsum };
            bike[2] = new bikes() { Name = "jatin", amt = 50, Rb_Button = radioButtonjatin, Labels =labeljatin };

            LabelUpdater();//this updates the lable
            bike[0].Bet_palced(0,0);
            bike[1].Bet_palced(0,0);
            bike[2].Bet_palced(0,0);

            labelMinimumBet.Text = "Min bet: "+updownmoney.Value.ToString()+" bucks";
          
        }

       
 
        private void Racer_Click(object sender, EventArgs e)
        {
            gb1.Enabled = false;
            timer1.Start();
            race[0] = new racers();
            race[0].Randomizer = random;
            race[0].piture = pictureBox1;
            race[0].StartingPoint = pictureBox1.Left;


            race[1] = new racers();
            race[1].Randomizer = random;
            race[1].piture = pictureBox2;
            race[1].StartingPoint = pictureBox1.Left;

            race[2] = new racers();
            race[2].Randomizer = random;
            race[2].piture = pictureBox3;
            race[2].StartingPoint = pictureBox1.Left;

            race[3] = new racers();
            race[3].Randomizer = random;
            race[3].piture = pictureBox4;
            race[3].StartingPoint = pictureBox1.Left;
        }

        private void timer1_Tick(object sender, EventArgs e) //This is the timer
        {
            int winner;
            for(int i=0; i<4; i++)//this is a for loop
            {
                if(race[i] != null)
                {
                    race[i].Move();
                    if(race[i].Move())
                    {
                        timer1.Stop();
                        
                        winner = i+1;
                        MessageBox.Show("bike " + winner);
                        win_cash(winner);
                        gb1.Enabled = true;
                        for (int k=0; k<4; k++)//this is a for loop
                        {
                            race[k].Startbike();
                        }
                    }
                    
                }
            }
        }
        private void win_cash(int bike_Win)
        {
            for (int i = 0; i < 3; i++)
            {
                bike[i].winer_bik(bike_Win);
            }
        }

        private void Bet_Click(object sender, EventArgs e)//this is for the beating
        {
            if(radioButtongill.Checked)
            {
                if (bike[0].Bet_palced((int)updownmoney.Value, (int)updownbike.Value))
                {                    
                    labelgill = bike[0].Labels;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");//this is for the message box
                    bike[0].Bet_palced(0, 0); 
                }
            }
            else if(radioButtonsum.Checked)
            {
                if (bike[1].Bet_palced((int)updownmoney.Value, (int)updownbike.Value))
                {
                    labelgill = bike[1].Labels;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");//this is for the message box
                    bike[1].Bet_palced(0, 0);
                }
            }
            else if(radioButtonjatin.Checked)
            {
                if (bike[2].Bet_palced((int)updownmoney.Value, (int)updownbike.Value))
                {
                    labelgill = bike[2].Labels;
                }
                else
                {
                    MessageBox.Show("You don't have enough money to bet");//this is for the message box
                    bike[2].Bet_palced(0, 0);
                }
            }
        }

        private void radioButtongill_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = bike[0].Name;
        }

        private void radioButtonsum_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = bike[1].Name;
        }

        private void radioButtonjatin_CheckedChanged(object sender, EventArgs e)
        {
            labelBetterName.Text = bike[2].Name;
        }

        private void LabelUpdater()//this updates the lable
        {
            for (int i = 0; i < 3; i++)
            {
                bike[i].UpdateLabels();
            }
        }

        

        private void raceTrackPicture_Click(object sender, EventArgs e)
        {

        }
    }
}
