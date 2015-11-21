using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD
{
    class Program
    {
        static int Main()
        {
            Player[] playerArr = gameInit();
            //Boolean gameStatus = true;

            printPlayers(playerArr);

            Console.ReadLine();
                return 0;
        }

        public static Player[] gameInit()
        {
            Console.WriteLine("How many adventurers are playing?");
            int playerCount = int.Parse(Console.ReadLine());
            Player[] playerArr = new Player[playerCount];

            Console.WriteLine();

            for (int i = 0; i < playerCount; i++)
            {
                Console.WriteLine("What is player " + (i + 1) + "'s name?");
                Player p = new Player(Console.ReadLine());

                Console.WriteLine("What is player " + (i + 1) + "'s class?");
                 p.setClass(Console.ReadLine());
                 Console.WriteLine();

                playerArr[i] = p;
            }

            //Console.WriteLine("Your current players are: ");

            //foreach (Player p in playerArr)
           // {
            //    Console.Write(p.getName() + " ");
            //}
            Console.WriteLine();
            return playerArr;
        }

        public static void printPlayers(Player[] arr)
        {
            foreach (Player p in arr)
            {
                p.display();
            }
        }
    }
}
