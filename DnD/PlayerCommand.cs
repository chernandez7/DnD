using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class PlayerCommand : Response
    {
        public string CommandName { get; private set; }
        private Game _game;

        public PlayerCommand(Game game)
        {
            CommandName = "player";
            this._game = game;
        }

        public string Help()
        {
            return @"Type 'player' to see the information of a character. Then the character name.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                Console.WriteLine("info for who?");
                return false;
            }
            string charName = command.SecondWord;

            foreach (Player p in _game.getPlayerArr())
            {
                if (p.getName() == charName)
                {
                    p.display();
                }
            }

            return false;
        }
    }
}
