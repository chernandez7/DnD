using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Dice
    {
        public Dice() {}

        public void roll(int die)
        {
            Random rnd = new Random();
            int number =  rnd.Next(1, die +1); //generates random number from 1 to # of sides of die

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("{0}-sided dice result is: ", die );
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(number);
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
