using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3TP3LIB
{
    public class Client
    {
        private string nom;
        private string prenom;
        private string adresse;
        private char categorie;

        public Client(string leNom, string lePrenom, string lAdresse, char laCategorie)
        {
            nom = leNom;
            prenom = lePrenom;
            adresse = lAdresse;
            categorie = laCategorie;
        }
        public string GetNom()
        {
            return nom;
        }

        public string GetPrenom()
        {
            return prenom;
        }

        public string GetAdresse()
        {
            return adresse;
        }

        public char GetCategorie()
        {
            return categorie;
        }

        public void SetNom(string nouvNom)
        {
            nom = nouvNom;
        }

        public void SetPrenom(string nouvPrenom)
        {
            prenom = nouvPrenom;
        }

        public void SetAdresse(string nouvAdresse)
        {
            adresse = nouvAdresse;
        }

        public void SetCategorie(char nouvCategorie)
        {
            categorie = nouvCategorie;
        }
    }
}
