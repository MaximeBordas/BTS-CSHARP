using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp10Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCarre100PremiersEntiers();
            Console.ReadLine();
        }
        static  void CalcCarre100PremiersEntiers()
        {
            int carre;
            for (int nb = 1; nb <= 100; nb++)
            {
                carre = nb * nb;
                Console.WriteLine("Voici tout les carre de " + nb + " est de " + carre);
            }
        }
    }
}
