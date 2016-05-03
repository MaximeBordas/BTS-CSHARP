using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibCroisiere;

namespace TPGestionCrosisiere
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration de la liste
            List<Croisiere> LesCroisieres;
            //Création de la collection de type List
            LesCroisieres = new List<Croisiere>();

            //Variables
            int numéroCroisiere;
            string nomCroisiere;
            float prixCroisière;
            string NomDuPaquebot;
            int nombreMaxInscrit;
            int nombreInscrit;
            string saisie;
            string valSai;


            //réference a Croisiere
            Croisiere uneCroisiere;

            do
            {
                //saisie des caractèritique
                Console.WriteLine("Veuillez renseigner le numéro de la croisière");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out numéroCroisiere);

                Console.WriteLine("Veuillez rentrer le nom de la croisière");
                nomCroisiere = Console.ReadLine();

                Console.WriteLine("Veuillez saisir le prix de la croisière");
                valSai = Console.ReadLine();
                float.TryParse(valSai, out prixCroisière);

                Console.WriteLine("Veuillez saisir le nom du paquebot");
                NomDuPaquebot = Console.ReadLine();

                Console.WriteLine("Veuillez renseigner le nombre maximal de passager de la croisiere");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out nombreMaxInscrit);

                Console.WriteLine("Veuillez renseigner le nombre de passager inscrit a la croisiere");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out nombreInscrit);

                Console.WriteLine("Veuillez renseigner le nombre maximal de passager de la croisiere");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out nombreMaxInscrit);

                //creation d'une croisiere
                uneCroisiere = new Croisiere(numéroCroisiere, nomCroisiere, prixCroisière, NomDuPaquebot, nombreMaxInscrit, nombreInscrit);


                //Ajout a la liste
                LesCroisieres.Add(uneCroisiere);

                //Demande si l'user veux ajouter encore un film
                Console.WriteLine("Vouilez vous saisir une nouvelle croisiere ?");
                saisie = Console.ReadLine();


            } while (saisie == "oui");
        }
    }
}
