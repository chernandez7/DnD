using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class DiceCommand : Response
    {
        public string CommandName { get; private set; }
        private Dice _dice;

        public DiceCommand() 
        { 
            CommandName = "dice";
            _dice = new Dice();
        }

        public string Help()
        {
            return @"Type 'dice' to roll a die.";
        }

        public bool Execute(Command command)
        {
            //string charName = command.SecondWord;
            int diceNumber = int.Parse(UI.PromptLine("How many dice do you want to roll?\n"));

            if (diceNumber == 1)
            {
                int die = int.Parse(UI.PromptLine("How many sides for the die\n?"));
                _dice.roll(die);
            }

            if (diceNumber == 2)
            {
                int die = int.Parse(UI.PromptLine("How many sides for the first die?\n"));
                int die2 = int.Parse(UI.PromptLine("How many sides for the second die?\n"));
                _dice.roll2(die, die2);
            }

            if (diceNumber == 3)
            {
                int die = int.Parse(UI.PromptLine("How many sides for the first die?\n"));
                int die2 = int.Parse(UI.PromptLine("How many sides for the second die?\n"));
                int die3 = int.Parse(UI.PromptLine("How many sides for the third die?\n"));
                _dice.roll3(die, die2, die3);
            }

            if (diceNumber > 3) { Console.WriteLine("Why do you want to roll so many?\n");  }

            return false;
        }
    }
}
