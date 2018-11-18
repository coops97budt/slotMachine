using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    //this class calls the play and view class to run the program
    class Program
    {
        static void Main(string[] args)
        {
            double cash = 100.00;
            View v = new View();
            double bet = v.getBet();
            Play p = new Play(bet, cash);


            
            
                int r1 = p.roll1();
                int r2 = p.roll2();
                int r3 = p.roll3();

                double updatedCash = p.winLoss();
                v.viewResult(r1, r2, r3);
                v.viewCash(cash, updatedCash);
            



            Console.ReadLine();
        }
    }
}
