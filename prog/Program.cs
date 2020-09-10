using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog
{
    class Program
    {
        static string[] tomb = new string[] { "kő", "papír", "olló" };
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
            Console.WriteLine("Játékos választása: {0}", tomb[b]);
            Console.WriteLine("Robot válasza \t Játékos válasza");
            Console.WriteLine("  {0} \t" + asd[embernyer(a, b)] + " \t{1}", tomb[a], tomb[b]);
        }
        static int gép()
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 3);
            return a;
        }
        static int választ()
        {
            Console.WriteLine("Válasszon: (1)Kő (2)Papír (3)Olló");
            int a = int.Parse(Console.ReadLine())-1;
            return a;
        }
        static void Main(string[] args)
        {
            bool tovabb = true;

            while (tovabb)
            {
                int robotval = gép();
                int jatekosv = választ();
                kiír(robotval, jatekosv);
                
                tovabb = jatszik();
                
            }
                    
        }
        static bool jatszik()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Akarsz játszani?[i/n]");
            string valasz = Console.ReadLine().ToLower();
            if (valasz=="i")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
