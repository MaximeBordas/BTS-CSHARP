using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCroisiere
{
    public class Croisiere
    {
        private int numCroisiere;
        private string nomCroisiere;
        private float prixPlaceCroisiere;
        private string nomPaquebot;
        private int nbrMaxInscrit;
        private int nbrInscrit;

        public int GetNumCroisiere()
        {
            return numCroisiere;
        }

        public string GetNomCroisiere()
        {
            return nomCroisiere;
        }

        public float GetPrixPlaceCroisiere()
        {
            return prixPlaceCroisiere;
        }

        public string GetNomPaquebot()
        {
            return nomPaquebot;
        }

        public int GetNbrMaxInscrit()
        {
            return nbrMaxInscrit;
        }

        public int GetNbrInscrit()
        {
            return nbrInscrit;
        }

        public void SetNumCroisiere(int unNum)
        {
            numCroisiere = unNum;
        }

        public void SetNomCroisiere(string unNom)
        {
            nomCroisiere = unNom;
        }

        public void SetPrixPlaceCroisiere(float unPrix)
        {
            prixPlaceCroisiere = unPrix;
        }

        public void SetNomPaquebot(string unNomPaquebot)
        {
            nomPaquebot = unNomPaquebot;
        }

        public void SetNbrMaxInscrit(int unNbrMax)
        {
            nbrMaxInscrit = unNbrMax;
        }

        public void SetNbrInscrit(int unNbr)
        {
            nbrInscrit = unNbr;
        }

        public Croisiere(int sonNum,string sonNom,float sonPrix,string sonNomPaquebot,int sonNbrMaxInscrit,int sonNbrInscrit)
        {
            numCroisiere = sonNum;
            nomCroisiere = sonNom;
            prixPlaceCroisiere = sonPrix;
            nomPaquebot = sonNomPaquebot;
            nbrMaxInscrit = sonNbrMaxInscrit;
            nbrInscrit = sonNbrInscrit;
        }

        public Croisiere(int sonNum, string sonNom, float sonPrix, string sonNomPaquebot, int sonNbrMaxInscrit)
        {
            numCroisiere = sonNum;
            nomCroisiere = sonNom;
            prixPlaceCroisiere = sonPrix;
            nomPaquebot = sonNomPaquebot;
            nbrMaxInscrit = sonNbrMaxInscrit;
            
        }

        public float RecetteSiPaquebotPlein()
        {
            float calcul;

            calcul = prixPlaceCroisiere + nbrMaxInscrit;
            return calcul;
        }

        public bool AEncoreDeLaPlace()
        {
            bool restePlace;

            if (nbrInscrit < nbrMaxInscrit)
            {
                restePlace = true;
            }

            else
            {
                restePlace = false;
            }
            return restePlace;
        }
    }
}
