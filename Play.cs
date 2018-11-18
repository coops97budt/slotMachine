using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    //this class handles all game functions
    class Play
    {
        private double Bet;
        private double Cash;
        private int r1;
        private int r2;
        private int r3;

        Random rn = new Random();

        public Play(double bet, double cash)
        {
            try
            {
                if (cash > bet)
                {
                    Bet = bet;
                }
                else
                {
                    Console.WriteLine("Invalid Bet Ammount \n");
                }
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int roll1()
        {
            r1 = rn.Next(0, 4); 
            

            return r1;
        }

        public int roll2()
        {
            r2 = rn.Next(0, 4);
            
            return r2;
        }

        public int roll3()
        {
            r3 = rn.Next(0, 4);
            
            return r3;

        }
        public double winLoss()
        {
            if (r1 == r2 && r1 == r3)
            {
                Cash =  Cash + (Bet * 2);
                return Cash;
            }
            else
            {
                Cash = Cash - Bet;
                return Cash;
            }

        }

        
        
    }
}
