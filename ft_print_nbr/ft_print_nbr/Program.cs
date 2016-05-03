using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ft_print_nbr
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbr;
            nbr = 0;

            do
            {
                Console.WriteLine(nbr);
                nbr++;
            } while (nbr <= 10);
            Console.ReadLine();
        } 
    }
}
