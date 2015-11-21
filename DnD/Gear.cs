using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Gear
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
            Console.WriteLine("Headgear: {0}\nArmor: {1}\nShoes: {2}\nGloves: {3}\nAccessory: {4}\nJewlery: {5}", _Headgear, _Armor, _Shoes, _Gloves, _Accessory, _Jewlery);
        }
    }
}
