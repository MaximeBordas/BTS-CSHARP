using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP10Exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcCarreSeriesEntiers(4, 50);
            CalcCarreSeriesEntiers(20, 100);
            Console.ReadLine();
        }
        static void CalcCarreSeriesEntiers(int debutCarre , int finCarre)
        {
            int carre;
            int nbr;
            for ( nbr = debutCarre; nbr <= finCarre; nbr++)
            {
                carre = nbr * nbr;
                Console.WriteLine("Le carré de " + nbr + " est de " + carre);
            }
        }
    }
}
