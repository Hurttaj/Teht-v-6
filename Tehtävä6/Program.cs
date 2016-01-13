using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtävä6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna matka kilometreinä:");
            float Matka = float.Parse(Console.ReadLine());
            Console.WriteLine("Bensaa kuluu " + Matka * 0.0702 + " litraa, kustannus " + Matka * 0.0702 * 1.595 + " euroa.");
        }
    }
}
