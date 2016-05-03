using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ft_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char c = 'a';

                do
                {
                    Console.WriteLine(c);
                    c++;
                } while (c <= 'z');
            Console.Read();
        }
    }
}
