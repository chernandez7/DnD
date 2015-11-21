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

        public int roll(int die)
        {
            Random rnd = new Random();
            int number =  rnd.Next(1, die +1);
            return number;
        }

         public int roll2(int die, int die2)
        {
            Random rnd = new Random();
             int number = rnd.Next(1, die+1) + rnd.Next(1,die2 +1) ;
            return number;
        }

         public int roll3(int die, int die2, int die3)
         {
             Random rnd = new Random();
             int number = rnd.Next(1, die + 1) + rnd.Next(1, die2 + 1) + rnd.Next(1, die3+1);
             return number;
         }
    }
}
