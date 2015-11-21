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
            _gear = new Gear();
            _stats = new StatSet();

            _stats.randomizeStats();

            _level = 1;
            _HP = 100;
            _MP = 100;
            _Gold = 50;
        }

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

        public void display()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Name: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_name + "\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Class: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_class + "\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Level: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_level + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("HP: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_HP + "\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("MP: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_MP + "\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Gold: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Gold + "\n");
            Console.ResetColor();
            Console.WriteLine();
        }

        public void displayAll()
        {
            display();
            _gear.display();
            _stats.display();
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
    }
}
