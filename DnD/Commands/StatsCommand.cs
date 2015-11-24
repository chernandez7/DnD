using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class StatsCommand : Response
    {
       public string CommandName { get; private set; }
       private Game _game;

        public StatsCommand(Game game) 
        {
        CommandName = "stats";
        this._game = game;
        }

        public string Help()
        {
            return @"Type 'stats' to see the stats of a character. Then the character name.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                Console.WriteLine("Stats for who?");
                return false;
            }
            string charName = command.SecondWord;

            foreach (Player p in _game.getPlayerArr())
            {
                if (p.getName() == charName)
                {
                    p.getStats().display();
                }
            }

            return false;
        }
    }
}
