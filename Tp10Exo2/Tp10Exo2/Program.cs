using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp10Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCarre(16);
            CalcCarre(32);
            Console.ReadLine();
        }
        static void CalcCarre(int nombre)
        {
            int carre;
            carre = nombre * nombre;
            Console.WriteLine(" Le carre de " + nombre + " est de " + carre);
        }
    }
}
