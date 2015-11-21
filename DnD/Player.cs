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
        private Gear _gear;
        private StatSet _stats;

        public void Player(String name, Gear gear, StatSet stats)
        {
            this._name = name;
            this._gear = gear;
            this._stats = stats;

            _level = 1;
            _HP = 100;
            _MP = 100;
            _Gold = 50;
        }
    }
}
