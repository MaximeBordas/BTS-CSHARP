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
            int resultat;
            CalcCarre(16 , out resultat);
            CalcCarre(32, out resultat);
            Console.ReadLine();
        }
        static void CalcCarre(int nombre, out int carre)
        {
           
            carre = nombre * nombre;
            Console.WriteLine(" Le carre de " + nombre + " est de " + carre);
        }
    }
}
