using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class DisplayCommand : Response
    {
        public string CommandName { get; private set; }
        private Game _game;

        public DisplayCommand(Game game)
        {
            CommandName = "display";
                this._game = game;
        }

        public string Help()
        {
            return @"Type 'display' to see all of the info of a character. Then the character name.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                foreach (Player p in _game.getPlayerArr())
                {
                    p.displayAll();
                    Console.WriteLine();
                }
                return false;
            }
            string charName = command.SecondWord;

            foreach (Player p in _game.getPlayerArr())
            {
                if (p.getName() == charName)
                {
                    p.displayAll(); //displays all info of a player
                }
            }

            return false;
        }
    }
}
