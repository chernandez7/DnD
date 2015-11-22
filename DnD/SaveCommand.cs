using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class SaveCommand : Response
    {
        public string CommandName { get; private set; }
        private Game _game;
        private StreamWriter writer;

        public SaveCommand(Game game)
        {
            this._game = game;
            CommandName = "save";
        }

        public string Help()
        {
            return @"Type 'save'to save your characters.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                Console.WriteLine("Save what story?");
                return false;
            }
            string fileName = command.SecondWord + ".txt";
            writer = new StreamWriter(fileName);
            writer.AutoFlush = true;

            var startTime = DateTime.Now;

            foreach (Player p in _game.getPlayerArr())
            {
                writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}\t{12}\t{13}\t{14}\t{15}\t{16}\t{17}", 
                    p.getName(), p.getClass(), p.getLevel(), p.getHP(), p.getMP(), p.getGold(),
                    p.getGear().getHeadgear(), p.getGear().getArmor(), p.getGear().getShoes(), p.getGear().getGloves(), p.getGear().getAccessory(), p.getGear().getJewlery(),
                    p.getStats().getSTR(), p.getStats().getDEX(), p.getStats().getCON(), p.getStats().getINT(), p.getStats().getWIS(), p.getStats().getCHA());
            }


            var totalSeconds = (DateTime.Now - startTime).TotalSeconds;
            Console.WriteLine("Character data saved in {0} seconds as {1}.", totalSeconds, fileName);
            writer.Close();
            return false;
        }

    }
}
