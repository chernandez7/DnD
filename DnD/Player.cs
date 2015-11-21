using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Player
    {
        private string _name;
        private string _class;
        private int _level;
        private int _HP;
        private int _MP;
        private int _Gold;
        private Gear _gear = new Gear();
        private StatSet _stats = new StatSet();

        public Player(String name)
        {
            this._name = name;

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
            Console.WriteLine("Name: {0}\tClass: {1}\tLevel: {2}\n\nHP: {3}\tMP: {4}\tGold: {5}\n", _name, _class, _level, _HP, _MP, _Gold);
            _gear.display();
            Console.WriteLine();
            _stats.display();
            Console.WriteLine();
        }
    }
}
