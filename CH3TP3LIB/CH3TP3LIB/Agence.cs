using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3TP3LIB
{
    public class Agence
    {
       private string nom;
       private string ville;
       private List<Compte> lesComptes;

        public Agence(string leNom, string laVille)
        {
            nom = leNom;
            ville = laVille;
            lesComptes = new List<Compte>();
        }

        public bool AjouteCompte(Compte unCompte)
        {
            bool trouve = false;
            int ind = 0;
            
            while(trouve==false && ind<lesComptes.Count)
            {
                if(lesComptes[ind] == unCompte)
                {
                    trouve = true;
                }

                else
                {
                    ind = ind++;
                }

                if(trouve == false)
                {
                    lesComptes.Add(unCompte);
                    trouve = true;
                    
                }

                else
                {
                    trouve = false;
                }
            }
            return trouve;
        }

        public int NbComptesEntreprises()
        {
            int ind = 0;
            int nbcompte = 0;

            if (lesComptes[ind].GetLeClient().GetCategorie()== ('E'))
            {
                nbcompte = nbcompte + 1;
            }

            else
            {
                ind++;
            }

            return nbcompte;
        }

        public float MontantDesEntreprisesCreditrices()
        {
            int ind = 0;
            float resultat = 0;

            if (lesComptes[ind].GetLeClient().GetCategorie() == 'E')
            {
                resultat = lesComptes[ind].GetSolde() + resultat;
            }

            else
            {
                ind++;
            }
            return resultat;
        }

        public void PreleveFraisGestion(float mtFrais)
        {
            
            float calcul = 0;

            foreach (Compte unCompte in lesComptes)
            {
                calcul = unCompte.GetSolde() - mtFrais;
                unCompte.SetSolde(calcul);
            }
        }

        public List<Compte> LesComptesDeParticuliers()
        {
            List<Compte> LesComptesDeParticuliers;
            LesComptesDeParticuliers = new List<Compte>();

            foreach(Compte unCompte in lesComptes)
            {
                if (unCompte.GetLeClient().GetCategorie()=='P')
                {
                    LesComptesDeParticuliers.Add(unCompte);
                }
            }
            return LesComptesDeParticuliers;
        }

        public bool ExistenceCompteClent(string nom , string prenom)
        {
            Client unClient;
            bool trouve = false;
            int ind = 0;
            while(trouve == false && ind < lesComptes.Count)
            {
                unClient = lesComptes[ind].GetLeClient();
                if (unClient.GetNom() == nom && unClient.GetPrenom()== prenom)
                {
                    trouve = true;
                }
                else
                {
                    trouve = false;
                    ind++;
                }
            }
            return trouve;
        }
    }
}
