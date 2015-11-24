using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class ResetCommand : Response
    {
        public string CommandName { get; private set; }

        public ResetCommand()
        {
            CommandName = "reset";
        }

        public string Help()
        {
            return @"Type 'reser' to reset the game.";
        }

        public bool Execute(Command command)
        {
            Console.Clear();
            Game game = new Game();
            game.play();


            return false;
        }
    }
}
