using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class ChangeCommand : Response
    {
        public string CommandName { get; private set; }
        private Game _game;

        public ChangeCommand(Game game)
        {
            CommandName = "change";
            this._game = game;
        }

        public string Help()
        {
            return @"Type 'change' to change something of the player. Then their name.";
        }

        public bool Execute(Command command)
        {
            if (!command.hasSecondWord())
            {
                // if there is no second word
                Console.WriteLine("Change who?");
                return false;
            }
            string charName = command.SecondWord;

            foreach (Player p in _game.getPlayerArr())
            {
                if (p.getName() == charName) //matches player
                {
                    Console.WriteLine("What would you like to change for " + p.getName() + "?\n");
                    string response = UI.PromptLine("stats, gear, or player\n");

                    Console.ForegroundColor = ConsoleColor.Red;

                    if (response == "stats")
                    {
                        string response2 = UI.PromptLine(" STR DEX CON INT WIS CHA ?\n");
                        int amount = UI.PromptInt("How much would you like to change " + response2 + " by?\n");
                        //STRENGTH
                        if (response2 == "STR")
                        {
                            p.getStats().setSTR(p.getStats().getSTR() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getSTR());

                        }
                        //DEXTERITY
                        if (response2 == "DEX")
                        {
                            p.getStats().setDEX(p.getStats().getDEX() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getDEX());
                        }
                        //CONSTITUTION
                        if (response2 == "CON")
                        {
                            p.getStats().setCON(p.getStats().getCON() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getDEX());
                        }
                        // INTELLIGENCE
                        if (response2 == "INT")
                        {
                            p.getStats().setINT(p.getStats().getINT() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getINT());
                        }
                        //WISDOM
                        if (response2 == "WIS")
                        {
                            p.getStats().setWIS(p.getStats().getWIS() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getWIS());
                        }
                        //CHARISMA   
                        if (response2 == "CHA")
                        {
                            p.getStats().setCHA(p.getStats().getCHA() + amount);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getStats().getCHA());
                        }
                    }
                    if (response == "gear")
                    {
                        string response2 = UI.PromptLine("Headgear Armor Shoes Gloves Accessory Jewlery ?\n");
                        string item = UI.PromptLine("What would you like to change " + response2 + " to?\n");
                        //Headgear;
                        if (response2 == "Headgear")
                        {
                            p.getGear().setHeadgear(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getHeadgear());
                        }
                        //Armor;
                        if (response2 == "Armor")
                        {
                            p.getGear().setArmor(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getArmor());
                        }
                        //Shoes;
                        if (response2 == "Shoes")
                        {
                            p.getGear().setShoes(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getShoes());
                        }
                        //Gloves;
                        if (response2 == "Gloves")
                        {
                            p.getGear().setGloves(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getGloves());
                        }
                        //Accessory;
                        if (response2 == "Accessory")
                        {
                            p.getGear().setAccessory(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getAccessory());
                        }
                        //Jewlery;
                        if (response2 == "Jewlery")
                        {
                            p.getGear().setJewlery(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGear().getJewlery());
                        }
                    }
                    if (response == "player")
                    {
                        string response2 = UI.PromptLine("Name Class Level HP MP Gold ?\n");
                        var item = UI.PromptLine("What would you like to change " + response2 + " to?\n");
                        // _name;
                        if (response2 == "Name")
                        {
                            p.setName(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getName());
                        }
                        //_class;
                        if (response2 == "Class")
                        {
                            p.setClass(item);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getClass());
                        }
                        //_level;
                        if (response2 == "Level")
                        {
                            p.setLevel(p.getLevel() + int.Parse(item));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getLevel());
                        }
                        // _HP;
                        if (response2 == "HP")
                        {
                            p.setHP(p.getHP() + int.Parse(item));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getHP());
                        }
                        // _MP;
                        if (response2 == "MP")
                        {
                            p.setMP(p.getMP() + int.Parse(item));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getMP());
                        }
                        // _Gold;
                        if (response2 == "Gold")
                        {
                            p.setGold(p.getGold() + int.Parse(item));
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("{0} has been changed to {1}", response2, p.getGold());
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
            return false;
        }
    }
}