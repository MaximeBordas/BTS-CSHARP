using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6CasAmioufRepetitif
{
    class Program
    {
        static void Main(string[] args)
        {
        //----------------------------------
        //Déclarations des constantes
        //----------------------------------
        // constante contenant le prix du kg de croquettes pour chat
        const float prixChat = 6;
        // constante contenant le taux de majoration du prix du kg de croquettes pour 
        // chat si vitaminée. 2.5 signifie 2,5 % de majoration
        const float txChatVitamine = 2.5f;
        // constante contenant le prix du kg de croquettes pour chien
        const float prixChien = 6.5f;
        // constante contenant le taux de majoration du prix du kg de croquettes pour 
        // chien si vitaminée 2.7 signifie 2,7 % de majoration
        const float txChienVitamine = 2.7f;

        const float txTVA = 19.6f;

        //----------------------------------
        //déclarations des variables
        //----------------------------------
        // variable contenant le prix du kg de croquettes
        float prix;
        // variable contenant le nombre de kg de croquettes à commander
        int qteCroq;
        // variable contenant le montant HT à payer pour les croquettes
        float montantHT;
        // variable contenant le montant de TVA à payer pour les croquettes
        float montantTVA;
        // variable contenant le montant TTC à payer pour les croquettes
        float montantTTC;
        // variable contenant le taux de remise
        float txRemise;
        // variable contenant le montant de la remise
        float montantRemise;
        // variable contenant le type de d'animal
        int typeAnimal;
        // variable contenant le type de croquette
        int typeCroq;
        // variable contenant le type de client
        char typeClient;
        // variable contenant la saisie de l'utilisateur
        string valeurSai;
        // booléen pour voir si le code est bon
        bool verifCode;


        // -------------------------------------------------------------------------------
        // saisie du type d'animal
        // -------------------------------------------------------------------------------
        do
        {
            Console.Write("Veuillez saisir l'animal à qui les croquettes sont destinées\n (1 pour chat, 2  pour chien) : ");
            valeurSai = Console.ReadLine();
            verifCode = int.TryParse(valeurSai, out typeAnimal);
            if (verifCode == false)
            {
                Console.Write("Retour a l'accueil \n");
            }
            else
            {
                if (typeAnimal != 1 && typeAnimal != 2)
                {
                    Console.Write("Veuillez saisir les infos valides qui sont 1(chat) ou deux(chien) : ");
                    valeurSai = Console.ReadLine();
                }
            }
        } while ((verifCode == false) || (typeAnimal != 1 && typeAnimal != 2));

        //-------------------------------------------------------------
        // saisie du type de croquette
        //--------------------------------------------------------------

        do
        {
            Console.Write("Veuillez saisir le type de croquette à commander \n(1 pour croquettes simples, 2 pour croquettes vitaminées) : ");
            valeurSai = Console.ReadLine();
            verifCode = int.TryParse(valeurSai, out typeCroq);
            if (verifCode == false)
            {
                Console.Write("Erreur dans la saisie , veuillez saisir une valeur correcte \n");
            }
            else
            {
                if (typeCroq != 1 && typeCroq != 2)
                {
                    Console.Write("Veuillez saisir les saisis valables , 1 pour les croquettes simples , 2 pour les vitaminées");
                } while (typeCroq != 1 && typeCroq != 2) ;

            }
        } while ((verifCode == false) ||(typeCroq != 1 && typeCroq != 2));
            //--------------------------------------
            // saisie du nombre de kilos a demander
            //--------------------------------------

            do
            {
                Console.Write("Veuillez saisir le nombre de kilos à commander : ");
                valeurSai = Console.ReadLine();
                verifCode = int.TryParse(valeurSai, out qteCroq);
                if (verifCode == false)
                {
                    Console.Write("Veuillez saisir un chiffre ou un nombre \n");
                }
                else
                {
                   if (qteCroq > 200)
                    {
                        Console.Write("La commande ne peut pas exceder 200 kg , veuillez saisir moins \n");
                        valeurSai = Console.ReadLine();
                        int.TryParse(valeurSai, out qteCroq);
                    }
                }while (qteCroq > 200);

            } while ((verifCode == false) || (qteCroq >200));
            //--------------------------------------
            // saisie du type de client 
            //--------------------------------------

            do
            {
                Console.Write("Veuillez saisir votre catégorie de client (A, B ou C) : ");
                valeurSai = Console.ReadLine();
                verifCode = char.TryParse(valeurSai, out typeClient);
                if (typeClient != 'A' && typeClient != 'B' && typeClient != 'C')
                {
                    Console.Write("Vous avez une catégorie érronée , veuillez choisir entre A , B ou C : \n");
                    valeurSai = Console.ReadLine();
                    char.TryParse(valeurSai, out typeClient);
                    char.ToUpper(typeClient);
                } 
            } while (typeClient != 'A' && typeClient != 'B' && typeClient != 'C');

                
        //--------------------------------------
        // Prix type animal + type de croquette
        //--------------------------------------
        if (typeAnimal == 1)
            if (typeCroq == 1)
                prix = prixChat;
            else
                prix = prixChat + prixChat * txChatVitamine / 100;
        else
            if (typeCroq == 1)
                prix = prixChien;
            else
                prix = prixChien + prixChien * txChienVitamine / 100;
                
        //--------------------------------------
        // Prix suivant la catégorie client 
        //--------------------------------------
        montantHT = prix * qteCroq;

        switch (typeClient)
        {
            case 'A':
                txRemise = 0.02f;
                break;
            case 'B':
                txRemise = 0.05f;
                break;
            case 'C':
                txRemise = 0.08f;
                break;
            default:
                txRemise = 0;
                break;
        }
        //--------------------------------------
        // Calcul de la remise 
        //--------------------------------------
        if (txRemise > 0)
        {
            montantRemise = txRemise * montantHT;
            Console.WriteLine("Votre taux de remise est de " + txRemise);
            Console.WriteLine("Le montant HT avant remise est de {0:n} euros ", montantHT);
            Console.WriteLine("Le montant de la remise est de {0:n} euros", montantRemise);
            montantHT = montantHT - montantRemise;
            Console.WriteLine("Le montant HT après remise est de {0:n} euros", montantHT);
        }
        else
            Console.WriteLine("Le montant HT est de {0:n} euros", montantHT);

        //--------------------------------------
        // calcul montant de TVA
        //--------------------------------------
        montantTVA = montantHT * txTVA / 100;
        Console.WriteLine("Le montant de TVA est de {0:n} euros", montantTVA);

        //--------------------------------------
        // Prix total avec TVA
        //--------------------------------------
        montantTTC = montantHT + montantTVA;
        Console.WriteLine("Le montant TTC est de {0:n} euros", montantTTC);

        Console.Read();

    }
}
}
