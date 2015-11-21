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

        public void Gear()
        {
            //Initialization of empty Gear set
            _Headgear = "";
            _Armor = "";
            _Shoes = "";
            _Gloves = "";
            _Accessory = "";
            _Jewlery = "";
        }

        public string getHeadgear();
        public void setHeadgear();
        public string getArmor();
        public void setArmor();
        public string getShoes();
        public void setShoes();
        public string getGloves();
        public void setGloves();
        public string getAccessory();
        public void setAccessory();
        public string getJewlery();
        public void setJewlery();


        public string getHeadgear()
        {
            return _headgear;
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
            return _Jewlery
        }

        public void setJewlery(String jewlery)
        {
            _Jewlery = jewlery
        }
    }
}
