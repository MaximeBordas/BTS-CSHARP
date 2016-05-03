using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP8
{
    class Program
    {
        static void Main(string[] args)
        {
            string  valSai;
            int     periodeAnalyseCA;
           

           

            string nomMoisearch;
            //déclaration du tableau contentant les mois

            string[] Lesmois = { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };

            int[] tva;
            //Variable de vérification
            bool verif;

            Console.WriteLine("Veuillez saisir la période d'analyse : 3 Mois , 6Mois ou 12 Mois");
            valSai = Console.ReadLine();
            verif = int.TryParse(valSai, out periodeAnalyseCA);
            if(verif == false || periodeAnalyseCA != 3 && periodeAnalyseCA != 6 && periodeAnalyseCA != 12)
            do
            {
                Console.WriteLine("Veuillez saisir une valeur valable : 3 ,6 ou 12");
                valSai = Console.ReadLine();
                verif = int.TryParse(valSai, out periodeAnalyseCA);

            } while (verif == false ||periodeAnalyseCA != 3 && periodeAnalyseCA != 6 && periodeAnalyseCA != 12);


            tva = new int[periodeAnalyseCA];
                for (int ind = 1; ind <= periodeAnalyseCA; ind++)
                    {
                        Console.WriteLine("Veuillez rentrer le CA du mois n°" + ind + ":");
                        valSai = Console.ReadLine();
                        int.TryParse(valSai, out tva[ind]);
                    }
                }
        

            
        }
    }

