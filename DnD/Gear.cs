using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class Gear
    {
        private string _Headgear;
        private string _Armor;
        private string _Shoes;
        private string _Gloves;
        private string _Accessory;
        private string _Jewlery;
        private string _LeftHand;
        private string _RightHand;
        private string _Etc;

        public Gear()
        {
            //Initialization of Gear set
            _Headgear = "NONE";
            _Armor = "NONE";
            _Shoes = "NONE";
            _Gloves = "NONE";
            _Accessory = "NONE";
            _Jewlery = "NONE";
            _LeftHand = "NONE";
            _RightHand = "NONE";
            _Etc = "NONE";
        }

        //accessors and mutators
        public string getHeadgear()
        {
            return _Headgear;
        }

        public void setHeadgear(String headgear)
        {
            _Headgear = headgear;
        }

        public string getArmor()
        {
            return _Armor;
        }

        public void setArmor(String armor)
        {
            _Armor = armor;
        }

        public string getShoes()
        {
            return _Shoes;
        }

        public void setShoes(String shoes)
        {
            _Shoes = shoes;
        }

        public string getGloves()
        {
            return _Gloves;
        }

        public void setGloves(String gloves)
        {
            _Gloves = gloves;
        }

        public string getAccessory()
        {
            return _Accessory;
        }

        public void setAccessory(String acc)
        {
            _Accessory = acc;
        }

        public string getJewlery()
        {
            return _Jewlery;
        }

        public void setJewlery(String jewlery)
        {
            _Jewlery = jewlery;
        }

        public string getWeapon1()
        {
            return _LeftHand;
        }

        public void setLeftHand(String weapon)
        {
            _LeftHand = weapon;
        }

        public string getLeftHand()
        {
            return _LeftHand;
        }

        public string getRightHand()
        {
            return _RightHand;
        }

        public void setRightHand(String weapon)
        {
            _RightHand = weapon;
        }

        public string getEtc()
        {
            return _Etc;
        }

        public void setEtc(String shield)
        {
            _Etc = shield;
        }

        public void display() //ToString of gear set
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Headgear: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Headgear ));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Armor: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Armor));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Shoes: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Shoes));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Gloves: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Gloves));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Accessory: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Accessory));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Jewlery: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Jewlery));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Left Hand: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _LeftHand));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Right Hand: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _RightHand));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "Etc: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _Etc));
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
