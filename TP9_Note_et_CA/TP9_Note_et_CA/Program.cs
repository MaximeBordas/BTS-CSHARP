using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP9_Note_et_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            #region //Variables
            int  nbrNote;
            string valSai;
            bool retconv;
            #endregion

            #region //L'user rentre le nombre de saisies qu'il va effectuer

            do
            {
                Console.WriteLine("veuillez saisir votre nombre de notes");
                valSai = Console.ReadLine();
                retconv = int.TryParse(valSai, out nbrNote);
                if (retconv == false || nbrNote < 1 || nbrNote > 50)
                {
                    Console.WriteLine("Afficher une valeur entre 1 et 50.");

                }

            } while (retconv == false || nbrNote < 1 || nbrNote > 50);
            float[] TabNote;
            TabNote = new float[50];
            #endregion






            #region //Saisie des notes en fonction du nombre 
            int ind;
            for (ind = 0; ind < nbrNote; ind++)
                {
                    do
                    { 
                    Console.WriteLine("Veuillez saisir la note n° " + (ind + 1) + "!");
                    valSai = Console.ReadLine();
                    retconv = float.TryParse(valSai, out TabNote[ind]);
                    if (retconv == false || TabNote[ind] < 0 || TabNote[ind] > 20)
                    {
                        Console.WriteLine("Veuillez saisir une note entre 0 et 20");
                    }
                    } while (retconv == false || TabNote[ind] < 0 || TabNote[ind] > 20) ;
                }
            #endregion

            do
            {
                Console.WriteLine("1 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("2 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("3 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("4 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("5 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("6 : Afficher le nombre de notes supérieures à 10");
                Console.WriteLine("9 : Afficher le nombre de notes supérieures à 10");
            } while (true);


        }
    }   
}
