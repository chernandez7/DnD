using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class ClearCommand : Response
    {
        public string CommandName { get; private set; }


        public ClearCommand()
        {
            CommandName = "clear";
        }

        public string Help()
        {
            return @"Type 'clear' to clear the screen of text.";
        }

        public bool Execute(Command command)
        {
           Console.Clear();

            return false;
        }

    }
}
