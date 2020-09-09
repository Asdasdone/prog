using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{
    class Program
    {
        static int embernyer(int a,int b)
        {
            //a=robot , b=ember
            //0= döntetlen 1= gép nyert 2= ember nyert
            int nyer = new int();
            if (a == 0 && b == 1 || a == 1 && b == 2 || a == 2 && b == 0)
            {
                nyer = 2;
            }
            else if (a == b)
            {
                nyer = 0;
            }
            else
            {
                nyer = 1;
            }
            return nyer;
        }
        static void kiír(int a,int b)
        {
            string[] asd = new string[] { "Döntetlen", "Vesztettél", "Nyertél" };
            string[] tomb = new string[] { "kő", "papír", "olló" };
            Console.WriteLine("Robot válasza \t Játékos válasza");
            Console.WriteLine("  {0} \t" + asd[embernyer(a, b)] + " \t{1}", tomb[a], tomb[b]);
        }
        static void Main(string[] args)
        {
            string[] tomb = new string[]{ "kő", "papír", "olló" };
            Random rnd = new Random();
            int robotval = rnd.Next(0, 3);
            
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
            kiír(robotval, jatekosv);
            Console.ReadKey();
        }
    }
}
