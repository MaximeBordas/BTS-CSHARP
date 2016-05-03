using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibAnimalerie
{
    public class Animal
    {
        private string nom;
        private string espece;
        private string cri;
        private int age;

        private string GetNom()
        {
            return nom;
        }

        private string GetEspece()
        {
            return espece;
        }

        private string GetCri()
        {
            return cri;
        }

        private int GetAge()
        {
            return age;
        }

        public void SetNom (string unNom)
        {
            nom = unNom;
        }

        public void SetEspece(string uneEspece)
        {
            espece = uneEspece;
        }

        public void SetCri(string unCri)
        {
            cri = unCri;
        }
        
        public void SetAge(int unAge)
        {
            age = unAge;
        }

        public Animal(string sonNom, string sonEspece, string sonCri, int sonAge)
        {
            nom = sonNom;
            espece = sonEspece;
            cri = sonCri;
            age = sonAge;
        }

        public void SePresenter()
        {
            Console.WriteLine("\nJe me présente : je m'appelle " + nom + ", et je suis de l'espèce " + espece + " et j'ai "+ age + " mois");
        }

        public void Dormir()
        {
            Console.WriteLine("\nZzz Zzz Zzz....(" + nom + "s'est endormi(e))");
        }

        public void Parler()
        {
            Console.WriteLine("\n" + cri + " ! !");
        }

        public void Parler(int nb)
        {
            for (int i = 0; i < nb; i++)
            {
                Console.WriteLine(cri + " ! !");
            }
            Console.WriteLine("\n");
        }

        public void Manger()
        {
            Console.WriteLine("J'avais si faim... Merci pour cette bonne nourriture !");
        }

    }
}
