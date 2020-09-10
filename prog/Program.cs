using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prog
{
    class Program
    {
        static int gepnyer= 0;
        static int jatekos = 0;
        static int kor = 0;
        static string[] tomb = new string[] { "kő", "papír", "olló" };
        static int embernyer(int a,int b)
        {
            //a=robot , b=ember
            //0= döntetlen 1= gép nyert 2= ember nyert
            int nyer = new int();
            if (a == 0 && b == 1 || a == 1 && b == 2 || a == 2 && b == 0)
            {
                jatekos++;
                nyer = 2;
            }
            else if (a == b)
            {
                nyer = 0;
            }
            else
            {
                gepnyer++;
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
        static void mentettstat()
        {
            Console.WriteLine("Körök\tJátékos    Gép ");
            Console.WriteLine("száma\tnyerése    nyerése\n----------------------------");
            StreamReader stat = new StreamReader("stat.txt");
            while (!stat.EndOfStream)
            {
                string[] sor = stat.ReadLine().Split(' ');
                for (int i = 0; i < sor.Length; i++)
                {
                    Console.Write(int.Parse(sor[i])+" \t   ");
                }
                Console.WriteLine("\n-----------------------");
            }
            stat.Close();
            Console.WriteLine("-------------------------Mentett statisztika vége-------------------\n");
        }
        static void Main(string[] args)
        {
            bool tovabb = true;
            mentettstat();

            while (tovabb)
            {
                kor++;
                int robotval = gép();
                int jatekosv = választ();
                kiír(robotval, jatekosv);
                
                tovabb = jatszik();
                Console.Clear();
                
            }
            statisztika();
            Console.ReadKey();
                    
        }
        static void statisztika()
        {
            if (jatekos>gepnyer)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Győzedelmes voltál");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A gép volt a győzedelmes");
            }
            Console.WriteLine("Körök száma: {0}",kor);
            Console.WriteLine("Győzelmed: {0} ({1}%)",jatekos,Convert.ToDouble(jatekos)/kor*100);
            Console.WriteLine("Gép győzelme: {0} ({1}%)", gepnyer, Convert.ToDouble(gepnyer) / kor * 100);

        }
        static bool jatszik()
        {
            
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
