using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DnD
{
    class Loader
    {
        private Game _game;

        public Loader(Game game)
        {
            this._game = game;
        }

        public static Player[] loadGame(String fileName)
        {
            var startTime = DateTime.Now;
                
            //Will only be here if file is valid already
            StreamReader reader = new StreamReader(fileName);
            int lineCount = File.ReadAllLines(fileName).Length;
            Player[] arr = new Player[lineCount];
            string[] sarr = new string[lineCount];

            //reads in all lines as a big string for each
            string temp;
            var j = 0;
            while ((temp = reader.ReadLine()) != null)
            {
                sarr[j] = temp;
                j++;
            }
            reader.Close(); //done with reading


            var i = 0;
            //need to parse lines into player info
            foreach (string s in sarr)
            {
                string[] dataArr = new string[18];

                dataArr = s.Split('-');

                arr[i] = new Player();

                arr[i].setName(dataArr[0]); //name
                arr[i].setClass(dataArr[1]); //class
                arr[i].setLevel(int.Parse(dataArr[2])); //level
                arr[i].setHP(int.Parse(dataArr[3])); //HP
                arr[i].setMP(int.Parse(dataArr[4])); //MP
                arr[i].setGold(int.Parse(dataArr[5])); //Gold

                arr[i].getGear().setHeadgear(dataArr[6]); //headgear
                arr[i].getGear().setArmor(dataArr[7]); //Armor
                arr[i].getGear().setShoes(dataArr[8]); //shoes
                arr[i].getGear().setGloves(dataArr[9]); //gloves
                arr[i].getGear().setAccessory(dataArr[10]); //accessory
                arr[i].getGear().setJewlery(dataArr[11]); //jewlery
                arr[i].getGear().setLeftHand(dataArr[12]); //Weapon1
                arr[i].getGear().setRightHand(dataArr[13]); //Weapon2
                arr[i].getGear().setEtc(dataArr[14]); //Shield


                arr[i].getStats().setSTR(int.Parse(dataArr[15])); //STR
                arr[i].getStats().setDEX(int.Parse(dataArr[16])); //DEX
                arr[i].getStats().setCON(int.Parse(dataArr[17])); //CON
                arr[i].getStats().setINT(int.Parse(dataArr[18])); //INT
                arr[i].getStats().setWIS(int.Parse(dataArr[19])); //WIS
                arr[i].getStats().setCHA(int.Parse(dataArr[20])); //CHA

                i++;
            }

            var totalSeconds = (DateTime.Now - startTime).TotalSeconds;

            Console.WriteLine("{0} loaded in {1} seconds.", fileName, totalSeconds);
            return arr;
        }
    }
}
