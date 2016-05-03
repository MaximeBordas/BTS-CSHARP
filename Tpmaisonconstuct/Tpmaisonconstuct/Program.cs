using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpmaisonconstuct
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GEV = 150000;
            const int ECO = 200000;
            const int LUX = 300000;

            char typeTerrain;
            string typeMaison;
            string valSaisie;
            float tailleTerrain;
            float txRemise;


            float prixAPayer = 0;
            float prixB =200;
            float prixL = (prixB *110)/100;
            float prixS = (prixB * 120) / 100;

            Console.Write("Type de maison demander : ");
            typeMaison = Console.ReadLine();
            typeMaison = typeMaison.ToUpper();
            typeMaison = typeMaison.Trim();
            Console.Write("Catégorie du terrain : ");
            valSaisie = Console.ReadLine();
            valSaisie = valSaisie.ToUpper();
            valSaisie = valSaisie.Trim();
            char.TryParse(valSaisie, out typeTerrain);
            Console.Write("Nombre de metre ² : ");
            valSaisie = Console.ReadLine();
            float.TryParse(valSaisie, out tailleTerrain);
            Console.Write("Remise et taux de celle ci : ");
            valSaisie = Console.ReadLine();
            float.TryParse(valSaisie, out txRemise); 


            if (typeMaison == "GEV")
            {
                prixAPayer = GEV;
            }

            else
            {
                if (typeMaison == "ECO")
                {
                    prixAPayer = ECO;
                }
                
                else
                {
                    if (typeMaison == "LUX")
                    {
                        prixAPayer = LUX;
                    }
                }
            }

            if (typeTerrain == 'B')
            {
                prixAPayer = prixAPayer + (prixB * tailleTerrain); 
            }

            else
            {
                if (typeTerrain == 'L')
                {
                    prixAPayer = prixAPayer + (prixL * tailleTerrain);
                }

                else
                {
                    if (typeTerrain == 'S')
                    {
                        prixAPayer = prixAPayer + (prixS * tailleTerrain);
                    }
                }
            }

            if (txRemise != 0)
            {
                prixAPayer = prixAPayer - (prixAPayer * txRemise / 100);
            }
            Console.WriteLine("Le prix est de " + prixAPayer);
            Console.ReadLine();
        }

    }
}
