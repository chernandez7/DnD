using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Player
    {
        private string _name;
        private string _class;
        private int _level;
        private int _HP;
        private int _MP;
        private int _Gold;
        private Gear _gear;
        private StatSet _stats;

        public Player()
        {
            //initialization of player and it's objects
            _gear = new Gear();
            _stats = new StatSet();
            _stats.randomizeStats(); //for now stats are just temporary
            _level = 1;
            _HP = 100;
            _MP = 100;
            _Gold = 50;
        }

        //accessors and mutators
        public void setName(string name)
        {
            _name = name;
        }

        public string getName()
        {
            return _name;
        }

        public void setClass(string c)
        {
        _class = c;
        }

        public string getClass()
        {
            return _class;
        }

        public void setLevel(int level)
        {
            _level = level;
        }

        public int getLevel()
        {
            return _level;
        }

        public void setHP(int hp)
        {
            _HP = hp;
        }

        public int getHP()
        {
            return _HP;
        }

        public void setMP(int mp)
        {
            _MP = mp;
        }

        public int getMP()
        {
            return _MP;
        }

        public void setGold(int gold)
        {
            _Gold = gold;
        }

        public int getGold()
        {
            return _Gold;
        }

        public void setGear(Gear set)
        {
            _gear = set;
        }

        public Gear getGear()
        {
            return _gear;
        }

        public void setStats(StatSet set)
        {
            _stats = set;
        }

        public StatSet getStats()
        {
            return _stats;
        }

        public void display() //ToString for player's basic info
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Name: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format( "{0,-12}", _name));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Class: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _class));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}","Level: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _level));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "HP: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _HP));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "MP: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _MP));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Gold: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Gold));
            Console.WriteLine("--------------------------------------------------------------");

            Console.ResetColor();
            Console.WriteLine();
        }

        public void displayAll() //Tostring for player info, gear, and stats together
        {
            display();
            _stats.display();
            _gear.display();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
