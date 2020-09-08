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
            string robotval = tomb[rnd.Next(0, 3)];
            //Console.WriteLine("Gép választása: {0}",robotval);
            string jatekosv = "";

            Console.ReadKey();
        }
    }
}
