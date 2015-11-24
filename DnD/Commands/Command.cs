using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Command
    {
        public string CommandWord { get; private set; }
        public string SecondWord { get; private set; }

        public static Command getCommand()
        {
            string cmd;
            string parameter = null;
            string line = UI.PromptLine("> ").Trim(); //compies command line input >

            int i = line.IndexOf(" ");
            if (i == -1)
            {
                cmd = line;
            }
            else //parses out command
            {
                cmd = line.Substring(0, i);
                parameter = line.Substring(i).Trim();
            }
            return new Command(cmd, parameter);
        }

        /// Create a command object. First and second word must be supplied, but
        /// either one (or both) can be null.
        public Command(string firstWord, string secondWord)
        {
            CommandWord = firstWord;
            SecondWord = secondWord;
        }

        /// Return true if the command has a second word.
        public bool hasSecondWord()
        {
            return (SecondWord != null);
        }
    }
}
