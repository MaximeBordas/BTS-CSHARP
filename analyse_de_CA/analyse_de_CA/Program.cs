using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace analyse_de_CA
{
    class Program
    {
        static void Main(string[] args)
        {
            //déclaration du tableau 
            int[] ChiffreAffaire = new int [12];

            int ind;
            string valSaisie;
            int periode;
            bool retconv;
            int CATotale=0;

            //saisie de la période d'analyse du chiffre d'affaires 
            do
            {
                Console.WriteLine("Veuillez saisir la période d'analyse du chiffre d'affaires (3 pour les 3 premiers mois, 6 pour les 6 premiers mois, 12 pour les 12 premiers mois de l'année)");
                valSaisie = Console.ReadLine();
                retconv = int.TryParse(valSaisie, out periode);

                if (retconv == false || (periode != 3 && periode != 6 && periode != 12))
                {
                    Console.WriteLine("Veuillez saisir soit 3,6 ou 12");
                }
            }
            while (retconv == false || (periode != 3 && periode != 6 && periode != 12));


            for ( ind =0 ; ind < periode; ind++)
            {
                Console.WriteLine("Veuillez saisir la période pour le mois n°" + (ind+1) + " :");
                valSaisie = Console.ReadLine();
                int.TryParse(valSaisie, out ChiffreAffaire[ind]);
             
            }
            //affichage du chiffre d'affaires maximum et de son numéro de mois correspondant 
            
            int numMoisMax=0;
            int max;
            max = ChiffreAffaire[0];
            for (ind=1;ind<12;ind++)
            {
                if(ChiffreAffaire[ind]>max)
                {
                    numMoisMax=ind;
                    max=ChiffreAffaire[ind];
                }

            }
            Console.WriteLine("Le max est " + max+" il est inscrit sur le mois n°" +(numMoisMax + 1));
            

            //affichage du chiffre d'affaire minimum et de son numéro de mois correspondant *

            int numMoisMin = 0;
            float min;
            min = ChiffreAffaire[0];
            for (ind = 1; ind < 12; ind++)
            {
                if (ChiffreAffaire[ind] < min)
                {
                    numMoisMin = ind;
                    min = ChiffreAffaire[ind];
                }

            }
            Console.WriteLine("Le min est " + min + " il est inscrit sur le mois n°" + (numMoisMin + 1));
            

            for (ind = 0; ind < 12; ind++)
            {
                CATotale = CATotale + ChiffreAffaire[ind];
            }
            Console.WriteLine("le Chiffre d'Affaire total de la période est " + CATotale+ ".");
            


            //recherche du premier mois trouvé qui est égal a un montant saisie 
            int CAComparer;
            Console.WriteLine("Veuillez saisir le CA que vous souhaitez comparer");
            valSaisie=Console.ReadLine();
            retconv= int.TryParse(valSaisie,out CAComparer);
            ind=0;

            for (ind = 0; ind < 12; ind++)
            {
                if (ChiffreAffaire[ind] > CAComparer)
                {
                    Console.WriteLine("Les mois pour lesquels le C.A est supérieur au montant saisie sont : " +ind);
                   
                }
            }

            Console.ReadLine();
        }
    }

}