using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3TP3LIB
{
    public class Compte
    {
        private int numCompte;
        private Client LeClient;
        private float solde;

        public int GetNumCompte()
        {
            return numCompte;
        }
        public Client GetLeClient()
        {
            return LeClient;
        }
        public float GetSolde()
        {
            return solde;
        }
        public void SetNumCompte(int nouvNum)
        {
            numCompte = nouvNum;
        }
        public void SetClient(Client nouvClient)
        {
            LeClient = nouvClient;
        }
        public void SetSolde(float nouvSolde)
        {
            solde = nouvSolde;
        }
        public Compte(int num,Client unClient,float leSolde )
        {
            numCompte = num;
            LeClient = unClient;
            solde = leSolde;
        }

        public void Debiter(float montant)
        {
            solde = solde - montant;
        }

        public void Crediter(float montant)
        {
            solde = solde + montant;
        }

        public bool EstDebiteur()
        {
            bool debiteur;
            if (solde > 0)
            {
                debiteur = true;
                return debiteur;
            }

            else
            {
                debiteur = false;
                return debiteur;
            }
        }

            public string GetNomClient()
        {
            return LeClient.GetNom();
        }
        }
}
