using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
         /// Map commands names to commands.
   public class CommandMapper
   {
      public string AllCommands {get; private set;}
      private Dictionary<string, Response> _responses; //responses to commands
       
      /// Initialize the command response mapping
		public CommandMapper(Game game)
      {
         _responses = new Dictionary<string, Response>();
         Response[] resp = {

            new Quitter(),
            new Helper(_responses, this),
			new StatsCommand (game),
			new GearCommand (game),
             new PlayerCommand (game),
            new DiceCommand (),
            new DisplayCommand(game),
            new ChangeCommand(game),
            new ClearCommand(),
            new SaveCommand(game)

         };
         AllCommands = "";
         foreach (Response r in resp) 
         {
            _responses[r.CommandName] = r;
            AllCommands += r.CommandName + " ";
         }
      }
   
      /// Check whether aString is a valid command word. 
      /// Return true if it is, false if it isn't.
      public bool isCommand(string aString)
      {
         return _responses.ContainsKey(aString);
      }
   
      /// Return the command associated with a command word.
      ///  cmdWord The command word.
      /// Return the Response for the command.
      public Response getResponse(string cmdWord)
      {
         return _responses[cmdWord];
      }
    }
}
