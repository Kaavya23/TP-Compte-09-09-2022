using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPTE_09_09_2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compte c, c1;
            c = new Compte();
            c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());
            Console.WriteLine(c1.ToString());
            Console.ReadLine();
        }
    }
}
