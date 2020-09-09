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
            Console.WriteLine("Gép választása: {0}",tomb[robotval]);
            Console.WriteLine("Válasszon: (1)Kő (2)Papír (3)Olló");
            int jatekosv = int.Parse(Console.ReadLine())-1;
            Console.WriteLine("Játékos választása: {0}",tomb[jatekosv]);
            /*switch (robotval+1)
            {
                case 1:
                    if (jatekosv==1)
                    {
                        Console.WriteLine("Nyertél");

                    }
                    else if (jatekosv==2)
                    {
                        Console.WriteLine("Vesztettél");
                    }
                    else
                    {
                        Console.WriteLine("Döntetlen");
                    }
                    ;break;
                case 2:
                    if (jatekosv == 2)
                    {
                        Console.WriteLine("Nyertél");

                    }
                    else if (jatekosv == 0)
                    {
                        Console.WriteLine("Vesztettél");
                    }
                    else
                    {
                        Console.WriteLine("Döntetlen");
                    }; break;
                case 3:
                    if (jatekosv == 0)
                    {
                        Console.WriteLine("Nyertél");

                    }
                    else if (jatekosv == 1)
                    {
                        Console.WriteLine("Vesztettél");
                    }
                    else
                    {
                        Console.WriteLine("Döntetlen");
                    }; break;
                default:
                    break;
            }*/
            if (robotval==0 && jatekosv==1 || robotval==1 && jatekosv==2 || robotval==2 && jatekosv==0)
            {
                Console.WriteLine("Nyertél");
            }
            else if (robotval==jatekosv)
            {
                Console.WriteLine("Döntetlen");
            }
            else
            {
                Console.WriteLine("Vesztettél");
            }
            Console.ReadKey();
        }
    }
}
