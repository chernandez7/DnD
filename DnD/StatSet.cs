using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    public class StatSet
    {
        private int _STR; //STRENGTH
        private int _DEX; //DEXTERITY
        private int _CON; //CONSTITUTION
        private int _INT; // INTELLIGENCE
        private int _WIS; //WISDOM
        private int _CHA; //CHARISMA
    
        public StatSet()
        {
            //Initialization of Stats
            _STR = 0;
            _DEX = 0;
            _CON = 0;
            _INT = 0;
            _WIS = 0;
            _CHA = 0;
        }

        public void randomizeStats()
        {
            Random rand = new Random();
            _STR = rand.Next(1, 31);
            _DEX = rand.Next(1, 31);
            _CON = rand.Next(1, 31);
            _INT = rand.Next(1, 31);
            _WIS = rand.Next(1, 31);
            _CHA = rand.Next(1, 31);
        }
    
    public void setSTR(int str)
    {
        _STR = str;
    }

        public int getSTR()
        {
            return _STR;
        }
            public void setDEX(int dex)
    {
        _DEX = dex;
    }

        public int getDEX()
        {
            return _DEX;
        }
    public void setCON(int con)
    {
        _CON = con;
    }

        public int getCON()
        {
            return _CON;
        }
    public void setINT(int i)
    {
        _INT = i;
    }

        public int getINT()
        {
            return _INT;
        }
    public void setWIS(int wis)
    {
        _WIS = wis;
    }

        public int getWIS()
        {
            return _WIS;
        }
    public void setCHA(int cha)
    {
        _CHA = cha;
    }

        public int getCHA()
        {
            return _CHA;
        }

        public void display()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "STR: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _STR));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "DEX: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _DEX));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "CON: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _CON));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "INT: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _INT));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "WIS: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(String.Format("{0,-12}", _WIS));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(String.Format("{0,-12}", "CHA: "));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(String.Format("{0,-12}", _CHA));
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
