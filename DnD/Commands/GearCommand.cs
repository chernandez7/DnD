using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class GearCommand : Response
    {
        public string CommandName { get; private set; }
        private Game _game;

        public GearCommand(Game game)
        {
            CommandName = "gear";
            this._game = game;
        }

        public string Help()
        {
            return @"Type 'gear' to see the gear of a character. Then the character name.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                Console.WriteLine("Gear for who?");
                return false;
            }
            string charName = command.SecondWord;

            foreach (Player p in _game.getPlayerArr())
            {
                if (p.getName() == charName)
                {
                    p.getGear().display();
                }
            }

            return false;
        }
    }
}
