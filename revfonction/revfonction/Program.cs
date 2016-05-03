using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revfonction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            printNbr();
            Console.ReadLine();
        }
        static void printAlphabet()
        {
            char c = 'a';
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c <= 'z');
        }
        static void printNbr()
        {
            int nbr;

            for (nbr = 0; nbr <= 20; nbr++)
            {
                Console.WriteLine(nbr);
            }
        }
    }
}
