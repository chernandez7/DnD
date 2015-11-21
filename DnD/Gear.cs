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
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
