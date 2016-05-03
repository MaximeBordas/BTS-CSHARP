using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libRessHum
{
    class Employe
    {
        private int numero;
        private string nom;
        private int age;
        private static int ageMin;
        private static float salMax;
        private float salAnnuel;
        private float montantVenteHt;

        public int GetNumero()
        {
            return numero;
        }
        public void SetNumero(int unNumero)
        {
            numero = unNumero;
        }

        public string GetNom()
        {
            return nom;
        }
        public void SetNom(string unNom)
        {
            nom = unNom;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int unAge)
        {
            age = unAge;
        }

        public static int GetAgeMin()
        {
            return Employe.ageMin;
        }
        public static void SetAgeMin(int unAgeMin)
        {
            Employe.ageMin = unAgeMin;
        }
        
        public static float GetSalMax()
        {
            return Employe.salMax;
        }
        public static void SetSalMax( float unSalMax)
        {
            Employe.salMax = unSalMax;
        }
        public float GetSalAnnuel()
        {
            return salAnnuel;
        }
        public void SetSalAnnuel(float unSalAnnuel)
        {
            salAnnuel = unSalAnnuel;
        }
        public float GetMontantVenteHt()
        {
            return montantVenteHt;
        }
        public void SetMontantVenteHt(float unMontantVenteHt)
        {
            montantVenteHt = unMontantVenteHt;
        }

        public Employe (int leNumero, string leNom, int leAge, float leSalAnnuel, float leMontantVenteHt)
        {
            numero = leNumero;
            nom = leNom;
            age = leAge;
            if (salMax < leSalAnnuel)
            {
                salAnnuel = salMax;
            }
            else
            {
                salAnnuel = leSalAnnuel;
            }
            montantVenteHt = leMontantVenteHt;
        }
            

    }
}
