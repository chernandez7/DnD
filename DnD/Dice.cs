using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Dice
    {
        private int _d4;
        private int _d6;
        private int _d8;
        private int _d10;
        private int _dPer; //Percentile 10-sided dice
        private int _d12;
        private int _d20;


        public int Dice()
        {
            _d4 = 4;
            _d6 = 6;
            _d8 = 8;
            _d10 = 10;
            _dPer = 10;
            _d12 = 12;
            _d20 = 20;
        }

        public int roll(int die); //generates number between 1 and side of die #
        public int roll2(int die, int die2); //generated number beteen 1 and side of die # for each die and adds them
        public int roll3(int die, int die2, int die3); //generated number beteen 1 and side of die # for each die and adds them

        public int roll(int die)
        {
            Random rnd = new Random();
            return int rnd.Next(1, die +1);
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
