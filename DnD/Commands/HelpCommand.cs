using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    /// Help Response
    public class HelpCommand : Response
    {
        public string CommandName { get; private set; }
        private CommandMapper _commandMapper;
        private Dictionary<string, Response> _responses;

        /// Print out some Help information.
        /// Here we print some stupid, cryptic message and a list of the 
        /// command words.
        public bool Execute(Command cmd)
        {
            if (!cmd.hasSecondWord())
            {
                Console.WriteLine("Are you confused?\n ");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("help");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' for help. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("player");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' for specific player info. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("gear");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' for viewing gear. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("stats");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' for viewing stats. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("dice");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' To roll dice. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("display");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' to view all of the info of a character at once. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("change");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' for changing a character. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("clear");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' to clear the screen of text. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("save");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' to save characters data in a file. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("reset");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' to reset the game. \n");
                Console.Write("Type '");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("quit");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("' to quit. \n");

            }
            else if (_responses.ContainsKey(cmd.SecondWord))
            {
                Console.WriteLine(_responses[cmd.SecondWord].Help());
            }
            else
            {
                Console.WriteLine(
    @"Unknown command {0}!  Command words are
    {1}", cmd.SecondWord, _commandMapper.AllCommands);
            }
            return false;
        }

        public string Help()
        {
            return @"Enter
    help command
for help on the command.";
        }

        /// Constructor for objects of class Helper
        public HelpCommand(Dictionary<string, Response> responses,
                      CommandMapper commandMapper)
        {
            this._responses = responses;
            this._commandMapper = commandMapper;
            CommandName = "help";

        }
    }
}
