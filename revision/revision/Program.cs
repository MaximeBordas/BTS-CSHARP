using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revision
{
    class Program
    {
        static void Main(string[] args)
        {
            string valSai;
            int ArgentDePoche;
            bool Verif;
            int ind;
            int[] nbrMois = new int[12];
            int NombreDeMois;
            int Menu;

            do //Saisie du nombre de mois
            {
                Console.WriteLine("Veuillez saisir votre nombre de mois");
                valSai = Console.ReadLine();
                Verif = int.TryParse(valSai, out NombreDeMois);

                if (Verif == false || NombreDeMois > 12)
                {
                    Console.WriteLine("Veuillez saisir un nombre ou chiffre , rappel ne se fait que pour une année la limite est 12 ! ");
                }
            } while (Verif == false || NombreDeMois > 12);



            do //On rempli le tableau avec les valeurs
            {
                for (ind = 0; ind < NombreDeMois; ind++)
                {
                    Console.WriteLine("Veuillez saisir votre argent de poche pour la periode n°" + (ind + 1));
                    valSai = Console.ReadLine();
                    Verif = int.TryParse(valSai, out nbrMois[ind]);

                    if (Verif == false)
                    {
                        Console.WriteLine("Veuillez saisir une valeur numérique pour la période numéro " + (ind+1));
                        valSai = Console.ReadLine();
                        int.TryParse(valSai, out nbrMois[ind]);
                    }

                }  
            } while (Verif == false);
            
            
            //Menu
            Console.WriteLine("Voulez vous savoir  La valeur Max ? Taper 1 La valeur Minimale ? taper 2");
            valSai = Console.ReadLine();
            int.TryParse(valSai, out Menu);


            
         
            if (Menu == 1)
            {       //Chercher la valeur Max d'un tableau
                int max;
                int moisMax = 0;
                max = nbrMois[0];

                for (ind = 1; ind < NombreDeMois; ind++)
                {
                    if (nbrMois[ind] > max)
                    {
                        max = nbrMois[ind];
                        moisMax = ind;
                    }
                }
                Console.WriteLine("Votre argent de poche max est " + max + "et est atteind au mois numéro " + (moisMax + 1));
                Console.ReadLine();
            }

            if (Menu == 2)
            {           // Chercher la valeur Min d'un tableau
                int min;
                int moisMin = 0;
                min = nbrMois[0];

                for(ind = 1; ind < NombreDeMois; ind++)
                {
                    if(nbrMois[ind] < min)
                    {
                        min = nbrMois[ind];
                        moisMin = ind;
                    }
                }
                Console.WriteLine("Votre argent de poche minimal est de " + min + "euros et est atteind au mois numéro " + (moisMin + 1));
                Console.ReadLine();
            }
        }
    }
}
