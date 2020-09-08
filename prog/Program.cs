using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tomb = new string[]{ "kő", "papír", "olló" };
            Random rnd = new Random();
            int robotval = rnd.Next(0, 3);
            //Console.WriteLine("Gép választása: {0}",tomb[robotval]);
            Console.WriteLine("Válasszon: (1)Kő (2)Papír (3)Olló");
            int jatekosv = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Játékos választása: {0}",tomb[jatekosv]);
            switch (robotval)
            {
                case 1:;break;
                case 2:;break;
                case 3:;break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
