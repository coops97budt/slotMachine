using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slot_Machine
{
    // this class prints all of the outputs
    class View
    {
        
        public double getBet()
        {

                Console.WriteLine("Enter bet");
                double bet = double.Parse(Console.ReadLine());
                return bet;
            

        }

        public void viewResult(int r1, int r2, int r3)
        {
            Console.WriteLine();
            switch (r1)
            {
                case 1:
                    Console.Write("BAR \t");
                    break;
                case 2:
                    Console.Write("CHERRY \t");
                    break;
                case 3:
                    Console.Write("$ \t");
                    break;
                default:
                    Console.Write("BELL \t");
                    break;
            }
            switch (r2)
            {
                case 1:
                    Console.Write("BAR \t");
                    break;
                case 2:
                    Console.Write("CHERRY \t");
                    break;
                case 3:
                    Console.Write("$ \t");
                    break;
                default:
                    Console.Write("BELL \t");
                    break;
            }
            switch (r3)
            {
                case 1:
                    Console.WriteLine("BAR \t");
                    break;
                case 2:
                    Console.WriteLine("CHERRY \t");
                    break;
                case 3:
                    Console.WriteLine("$ \t");
                    break;
                default:
                    Console.WriteLine("BELL \t");
                    break;
            }
        }

        public void viewCash(double cash, double updatedCash)
        {
            cash = cash + updatedCash;
            Console.WriteLine(cash);
        }
    }
}
