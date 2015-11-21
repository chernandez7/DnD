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

        public Gear()
        {
            //Initialization of Gear set
            _Headgear = "Iron Helmet";
            _Armor = "Chainmail";
            _Shoes = "Combat Boots";
            _Gloves = "Leather Gloves";
            _Accessory = "Silver Ring";
            _Jewlery = "Silver Pendant";
        }

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

        public void display()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Headgear: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Headgear + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Armor: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Armor + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Shoes: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Shoes + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Gloves: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Gloves + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Accessory: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Accessory + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Jewlery: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(_Jewlery + "\n");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
