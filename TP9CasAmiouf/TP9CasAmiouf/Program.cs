using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP6CasAmioufRepetitif
{
    class Program
    {
        static float PrixKgCommande (char typeCroquette, char typeAnimal)
        {
            // constante contenant le prix du kg de croquettes pour chat
            const float prixChat = 6;
            // constante contenant le taux de majoration du prix du kg de croquettes pour 
            // chat si vitaminée. 2.5 signifie 2,5 % de majoration
            const float tauxChatVitamine = 2.5f;
            // constante contenant le prix du kg de croquettes pour chien
            const float prixChien = 6.5f;
            // constante contenant le taux de majoration du prix du kg de croquettes pour 
            // chien si vitaminée 2.7 signifie 2,7 % de majoration
            const float tauxChienVitamine = 2.7f;
            // variable contenant le prix du kg de croquettes
            float prix = 0;


            if (typeAnimal == '1')
                if (typeCroquette == '1')
                    prix = prixChat;
                else
                    prix = prixChat + prixChat * tauxChatVitamine / 100;
            else
                if (typeCroquette == '1')
                prix = prixChien;
            else
                prix = prixChien + prixChien * tauxChienVitamine / 100;
            return prix;
        }

        static float TauxRemise (char typeCli)
        {
            float tauxRemiFonc;
            switch (typeCli)
            {
                case 'A':
                    tauxRemiFonc = 0.02f;
                    break;
                case 'B':
                    tauxRemiFonc = 0.05f;
                    break;
                case 'C':
                    tauxRemiFonc = 0.08f;
                    break;
                default:
                    tauxRemiFonc = 0;
                    break;
            }
            return tauxRemiFonc;
        }

        static void Main(string[] args)
        {
            //----------------------------------
            //
            //----------------------------------
            const float tauxTVA = 19.6f;

            //----------------------------------
            //
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
            float tauxRemise;
            // variable contenant le montant de la remise
            float montantRemise;
            // variable contenant le type de d'animal
            char typeAnimal;
            // variable contenant le type de croquette
            char typeCroq;
            // variable contenant le type de client
            char typeClient;
            // variable contenant la saisie de l'utilisateur
            string valeurSaisie;
            // booléen
            bool retConv;


            do
            {
                // -------------------------------------------------------------------------------
                // saisie du type d'animal
                // -------------------------------------------------------------------------------
                do
                {
                    Console.Write("Veuillez saisir l'animal à qui les croquettes sont destinées\n (1 pour chat, 2  pour chien) : ");
                    valeurSaisie = Console.ReadLine();
                    retConv = char.TryParse(valeurSaisie, out typeAnimal);
                    if (retConv == false)
                    {
                        Console.WriteLine("Veuillez saisir un seul caractère numérique");
                    }
                    else
                    {
                        if (typeAnimal != '1' && typeAnimal != '2')
                        {
                            Console.WriteLine("Veuillez saisir le 1 pour un chien et le 2 pour un chat");
                        }
                    }
                } while (retConv == false || typeAnimal != '1' && typeAnimal != '2');

                //-------------------------------------------------------------
                // saisie du type de croquette
                //--------------------------------------------------------------

                do
                {
                    Console.Write("Veuillez saisir le type de croquette à commander \n(1 pour croquettes simples, 2 pour croquettes vitaminées) : ");
                    valeurSaisie = Console.ReadLine();
                    retConv = char.TryParse(valeurSaisie, out typeCroq);
                    if (retConv == false)
                    {
                        Console.WriteLine("Veuillez saisir un seul caractère numérique");
                    }
                    else
                    {
                        if (typeCroq != '1' && typeCroq != '2')
                        {
                            Console.WriteLine("Veuillez saisir le 1 pour les croquettes simples et le 2 pour les croquettes vitmainées");
                        }
                    }
                } while (retConv == false || typeCroq != '1' && typeCroq != '2');

                //--------------------------------------
                // 
                //--------------------------------------

                do
                {
                    Console.Write("Veuillez saisir le nombre de kilos à commander : ");
                    valeurSaisie = Console.ReadLine();
                    retConv = int.TryParse(valeurSaisie, out qteCroq);
                    if (retConv == false)
                    {
                        Console.WriteLine("Veuillez saisir un caractère numérique");
                    }
                    else
                    {
                        if (qteCroq > 200 || qteCroq < 1)
                        {
                            Console.WriteLine("Vous ne pouvez commander que 200 kilos à la fois");
                        }
                    }
                } while (retConv == false || qteCroq > 200 || qteCroq < 1);

                //--------------------------------------
                // 
                //--------------------------------------

                do
                {
                    Console.Write("Veuillez saisir votre catégorie de client (A, B ou C) : ");
                    valeurSaisie = Console.ReadLine();
                    valeurSaisie = valeurSaisie.ToUpper();
                    retConv = char.TryParse(valeurSaisie, out typeClient);
                    if (retConv == false)
                    {
                        Console.WriteLine("Veuillez saisir un seul caractère numérique");
                    }
                    else
                    {
                        if (typeClient != 'A' && typeClient != 'B' && typeClient != 'C')
                        {
                            Console.WriteLine("Veuillez saisir votre catégorie de client (A, B ou C)");
                        }
                    }
                } while (retConv == false || typeClient != 'A' && typeClient != 'B' && typeClient != 'C');


                //--------------------------------------
                // 
                //--------------------------------------

                prix = PrixKgCommande(typeCroq, typeAnimal);
                Console.WriteLine("Le prix d'un kilog de croquette est de : " + prix);

                //--------------------------------------
                // 
                //--------------------------------------
                montantHT = prix * qteCroq;

                tauxRemise = TauxRemise(typeClient);
                
                //--------------------------------------
                // 
                //--------------------------------------
                if (tauxRemise > 0)
                {
                    montantRemise = tauxRemise * montantHT;
                    Console.WriteLine("Votre taux de remise est de " + tauxRemise);
                    Console.WriteLine("Le montant HT avant remise est de {0:n} euros ", montantHT);
                    Console.WriteLine("Le montant de la remise est de {0:n} euros", montantRemise);
                    montantHT = montantHT - montantRemise;
                    Console.WriteLine("Le montant HT après remise est de {0:n} euros", montantHT);
                }
                else
                    Console.WriteLine("Le montant HT est de {0:n} euros", montantHT);

                //--------------------------------------
                // 
                //--------------------------------------
                montantTVA = montantHT * tauxTVA / 100;
                Console.WriteLine("Le montant de TVA est de {0:n} euros", montantTVA);

                //--------------------------------------
                // 
                //--------------------------------------
                montantTTC = montantHT + montantTVA;
                Console.WriteLine("Le montant TTC est de {0:n} euros", montantTTC);

                Console.WriteLine("Voulez-vous reccommencer votre commande ?");
                valeurSaisie = Console.ReadLine();
                valeurSaisie = valeurSaisie.ToLower();

                Console.Read();
            } while (valeurSaisie == "o");
        }
    }
}
