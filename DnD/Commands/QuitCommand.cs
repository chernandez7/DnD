﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
        /// Quit Response 
   public class QuitCommand : Response
   {
      public string CommandName {get; private set;}

      public QuitCommand()
      {
         CommandName = "quit";
      }
   
      /// "Quit" was entered. Check the rest of the command to see
      /// whether we really quit the game.
      /// Return true, if this command quits the game, false otherwise.
      public bool Execute(Command command)
      {
         if(command.hasSecondWord()) {
            Console.WriteLine("Quit what?");
            return false;
         }
         else {
            return UI.Agree("Do you really want to quit?");
         }
      }

      public string Help()
      {
         return @"Enter quit to quit the game.";
      }
    }
}
