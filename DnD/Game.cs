﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Additions to be made:
 * 
 * Implement classes
 * randomize stats following actual rules
 * weapons!
 * battle system
 */

namespace DnD
{
    public class Game
    {
        private CommandMapper _commandMapper;
        private Player[] _playerArr;

        /// Create the game.
        public Game()
        {
            _commandMapper = new CommandMapper(this);
            _playerArr = gameInit();
        }

        ///  Main play routine.  Loops until end of play.
        public void play()
        {
            // Enter the main command loop.  Here we repeatedly read commands and
            // Execute them until the game is over.
            while (!processCommand(Command.getCommand()))
                ;  // convention with isolated semiclon for an empty loop
            Console.WriteLine("Thank you for playing!");
        }

        static int Main()
        {
            Console.SetWindowSize(Console.LargestWindowWidth - 5, Console.LargestWindowHeight - 5);
            Console.ForegroundColor = ConsoleColor.Yellow;

            Game _game = new Game();

            _game.play();

            return 0;
        }

        public Player[] gameInit()
        {
            Player[] Arr;

            Console.ForegroundColor = ConsoleColor.Yellow;
            bool loadStatus = UI.Agree("Would you like to load a previous save file?");
            
            if (loadStatus) //if user wants to load then give options and load chosen one
            {
                //http://stackoverflow.com/questions/14877237/getting-all-file-names-from-a-folder-using-c-sharp
                string[] fileArray = Directory.GetFiles(@"C:\Users\Chris\repos\DnD\DnD\bin\Debug\", "*.txt", SearchOption.AllDirectories);

                Console.ForegroundColor = ConsoleColor.Red;

                foreach (String s in fileArray) //parses and prints out all text files already in project
                {
                    string temp = s.Substring(s.IndexOf("g") + 2);
                    string r = temp.Replace(".txt", "");
                    Console.Write(String.Format("{0,-15}", r));
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                string fileName = UI.PromptLine("What game would you like to load?\n");


                while (!File.Exists(@"C:\Users\Chris\repos\DnD\DnD\bin\Debug\" + fileName + ".txt")) //if file doesn't exist in case of typo
                {

                       if (fileName == "") { fileName = UI.PromptLine("No file chosen. What game would you like to load?\n");  }

                       if  (fileName == "q") //option to quit to not get stuck in menu
                       {
                           bool quitStatus = UI.Agree("Are you sure that you want to quit?");
                           if (quitStatus) { Environment.Exit(-1); }
                           else { fileName = UI.PromptLine("What game would you like to load?\n"); }
                       }
                        Console.WriteLine("File: " + fileName + ".txt does not exist. Please enter a valid file name, start a new game, or type 'q' to quit.\n");
                        fileName = UI.PromptLine("What game would you like to load?\n");
                }

                //if here then ok to load file and exists
                Arr = Loader.loadGame(fileName + ".txt");
            }
            else //if user chose to make a new instance of game
            {
                int playerCount = UI.PromptInt("How many adventurers are playing?\n");
                Arr = new Player[playerCount];

                Console.WriteLine();

                for (int i = 0; i < playerCount; i++)
                {
                    Player p = new Player();
                    p.setName(UI.PromptLine("What is player " + (i + 1) + "s name?\n"));
                    p.setClass(UI.PromptLine("What is player " + (i + 1) + "s class?\n"));
                    Console.WriteLine();

                    Arr[i] = p;
                }
            }
         
            printWelcome();

            Console.WriteLine();
            return Arr;
        }

        public void printWelcome()
        {
            //http://www.chris.com/ascii/index.php?art=creatures/dragons
            //credit for ASCII art
            Console.WriteLine(@"
                                  /   \       
 _                        )      ((   ))     (
(@)                      /|\      ))_((     /|\
|-|                     / | \    (/\|/\)   / | \                      (@)
| | -------------------/--|-voV---\`|'/--Vov-|--\---------------------|-|
|-|                         '^`   (o o)  '^`                          | |
| |                               `\Y/'                               |-|
|-|                                                                   | |
| |                           Created by Chris                        |-|
|-|                                                                   | |
| |                                                                   |-|
|_|___________________________________________________________________| |
(@)              l   /\ /         ( (       \ /\   l                `\|-|
                 l /   V           \ \       V   \ l                  (@)
                 l/                _) )_          \I
                                   `\ /'
				     `  
           ");

            //Printing out commands
            Console.WriteLine();
            Console.WriteLine("Welcome to Dungeons & Dragons!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();
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
            Console.Write("' to save the information of the characters. \n");
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

        /// Given a command: process (that is: Execute) the command.
        /// Return true If the command ends the game, false otherwise.
        private bool processCommand(Command command)
        {
            if (!_commandMapper.isCommand(command.CommandWord))
            {
                Console.WriteLine("Try something different.");
                return false;
            }
            Response response = _commandMapper.getResponse(command.CommandWord);
            return response.Execute(command);

        }
    
    public Player[] getPlayerArr()
        {
            return _playerArr;
        }

    bool isString(object value)
    {
        return value is string;
    }
    }
}
