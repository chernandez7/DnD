using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
        /// Object that responds to a command
        public interface Response
        {
            /// Execute cmd.
            /// Return true if the game is over; false otherwise 
            bool Execute(Command cmd);

            /// Return a Help string for the command 
            string Help();


            string CommandName { get; }
        }
}
