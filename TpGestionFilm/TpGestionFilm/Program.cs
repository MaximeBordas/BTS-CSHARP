using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibFilm;

namespace TpGestionFilm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration de la liste
            List<Film> LesFilms;
            //Création de la collection de type List
            LesFilms = new List<Film>();

            //Variables
            string saisi;
            string Titre;
            int NbrEnfants;
            int NbrAdultes;
            string valSai;

            //Référence a Film
            Film unFilm;

            do
            {
                //Saisie des caractéristiques
                Console.WriteLine("Veuillez saisir le titre du film.");
                Titre = Console.ReadLine();

                Console.WriteLine("Veuillez saisir le nombre d'enfant.");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out NbrEnfants);

                Console.WriteLine("Veuillez saisir le nombre d'adulte.");
                valSai = Console.ReadLine();
                int.TryParse(valSai, out NbrAdultes);

                //création d'un film
                unFilm = new Film(Titre, NbrEnfants, NbrAdultes);

                //ajout du film crée dans la collection
                LesFilms.Add(unFilm);

                //Demande si l'user veux ajouter encore un film
                Console.WriteLine("Vouilez vous saisir un nouveau film ?");
                saisi = Console.ReadLine();
            } while (saisi == "oui");

            float leRacette;
            float calcul = 0;

            foreach (Film fil in LesFilms)
            {
                leRacette = fil.Recette();
                calcul = calcul + leRacette;

                
            }
            Console.WriteLine("Le prix est de " + calcul + " euros");



            int nombreTotalEntree;
            //Tout les films qui on fait plus de 300 ou égale a 300 
            foreach(Film fil in LesFilms)
            {
                nombreTotalEntree = fil.GetNombreAdulte() + fil.GetNombreEnfant();

                if (nombreTotalEntree >= 300)
                { 
                    Console.WriteLine("Il y a " + nombreTotalEntree + "  specateurs dans la salle pour le film " + fil.GetTitre());
                }
            }


            //Tput les films sans spécateur
            foreach(Film fil in LesFilms)
            {
                if(fil.AucuneEntree() == true )
                {
                    Console.WriteLine(fil.GetTitre() + " n'a eu aucun spectateurs");
                }
            }

            Console.ReadLine();            
        }
    }
}
