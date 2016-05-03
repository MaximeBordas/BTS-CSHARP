using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    class Program
    {
        static float Calculette(float nbr1 , char operateur ,float nbr2)
        {
            float resultat= 0;

            switch (operateur)
            {
                
                case '+':
                    resultat = nbr1 + nbr2;
                    break;
                case '-':
                    resultat = nbr1 - nbr2;
                    break;
                case '*':
                    resultat = nbr1 * nbr2;
                    break;
                case '/':
                    resultat = nbr1 / nbr2;
                    break;
            }
            return resultat;
        }
        static void Main(string[] args)
        {
            float nombre1;
            float nombre2;
            float resultCalc;
            char opérant;
            string valSai;

            Console.WriteLine("Veuillez saisir le nombre 1 : ");
            valSai = Console.ReadLine();
            float.TryParse(valSai, out nombre1);

            Console.WriteLine("Veuillez saisir l'opérateur + , - , * , /");
            valSai = Console.ReadLine();
            char.TryParse(valSai, out opérant);

            Console.WriteLine("Veuillez saisir le nombre 2 : ");
            valSai = Console.ReadLine();
            float.TryParse(valSai, out nombre2);

           resultCalc = Calculette(nombre1, opérant, nombre2);
            Console.WriteLine(resultCalc);
            Console.ReadLine();
        }
    }
}
