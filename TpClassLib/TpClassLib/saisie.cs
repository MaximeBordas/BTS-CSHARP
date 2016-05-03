using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpClassLib
{
    /// <summary>
    /// Procédure 
    /// </summary>
    public class saisie
        
    {
        //Saisie d'un entier sans contrôle de saisie en int
        /// <summary>
        /// Permet la saisie d'une information de type entier sans controle de saisie
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="valRetournee">valeur saisie convertie en type entier</param>
        public static void SaisieNumerique(string msgInfo, out int valRetournee)
        {
            string valSaisie;
            Console.WriteLine(msgInfo);
            valSaisie = Console.ReadLine();
            int.TryParse(valSaisie, out valRetournee);
        }

        //Saisie d'un entier sans contrôle de saisie en float
        /// <summary>
        /// Permet la saisie d'une information de type float sans controle de saisie
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="valRetournee">valeur saisie convertie en type float</param>
        public static void SaisieNumerique(string msgInfo, out float valRetournee)
        {
            string valSaisie;
            Console.WriteLine(msgInfo);
            valSaisie = Console.ReadLine();
            float.TryParse(valSaisie, out valRetournee);
        }

        //Saisie d'un entier avec contrôle de saisie en int
        /// <summary>
        /// Permet la saisie d'une information de type entier avec controle de saisie
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="valRetournee">valeur saisie convertie en type entier</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, out int valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = int.TryParse(valSaisie, out valRetournee);
                if (retConv == false)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false);
        }

        //Saisie d'un entier avec contrôle de saisie en float
        /// <summary>
        /// Permet la saisie d'une information de type float avec controle de saisie
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="valRetournee">valeur saisie convertie en type float</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, out float valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = float.TryParse(valSaisie, out valRetournee);
                if (retConv == false)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false);
        }

        //Saisie d'un entier avec contrôle de saisie en int et avec une borne de valeur minimale
        /// <summary>
        /// Permet la saisie d'une information de type int avec controle de saisie avec une borne definie par l'uttilisateur
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="borneInf">borne renseigner par l'uttilisateur</param>
        /// <param name="valRetournee">valeur saisie convertie en type entier</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, int borneInf, out int valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = int.TryParse(valSaisie, out valRetournee);
                if (retConv == false || valRetournee < borneInf)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false || valRetournee < borneInf);
        }

        //Saisie d'un entier avec contrôle de saisie en float et avec une borne de valeur minimale
        /// <summary>
        /// Permet la saisie d'une information de type float avec controle de saisie avec une borne definie par l'uttilisateur
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="borneInf">borne renseigner par l'uttilisateur</param>
        /// <param name="valRetournee">valeur saisie convertie en type float</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, float borneInf, out float valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = float.TryParse(valSaisie, out valRetournee);
                if (retConv == false || valRetournee < borneInf)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false || valRetournee < borneInf);
        }

        //Saisie d'un entier avec contrôle de saisie en int et avec une borne de valeur minimale et une borne de valeur maximale
        /// <summary>
        /// Permet la saisie d'une information de type int avec controle de saisie avec une borne pour  definir le debut par l'uttilisateur et l'autre borne pour le maximal
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="borneInf">borne renseigner par l'uttilisateur</param>
        /// <param name="borneSup">borne de la valeur maximale qui doit etre atteinte</param>
        /// <param name="valRetournee">valeur saisie convertie en type int</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, int borneInf, int borneSup, out int valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = int.TryParse(valSaisie, out valRetournee);
                if (retConv == false || borneSup < borneInf)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false || borneSup < borneInf);
        }
        //Saisie d'un entier avec contrôle de saisie en float et avec une borne de valeur minimale et une borne de valeur maximale
        /// <summary>
        /// Permet la saisie d'une information de type float avec controle de saisie avec une borne pour  definir le debut par l'uttilisateur et l'autre borne pour le maximal
        /// </summary>
        /// <param name="msgInfo">message d'information indiquant la nature de la valeur a saisir</param>
        /// <param name="msgErreur">message d'erreur en cas de mauvaise saisie de l'uttilisateur</param>
        /// <param name="borneInf">borne renseigner par l'uttilisateur</param>
        /// <param name="borneSup">borne de la valeur maximale qui doit etre atteinte</param>
        /// <param name="valRetournee">valeur saisie convertie en type float</param>
        public static void SaisieNumerique(string msgInfo, string msgErreur, float borneInf, float borneSup, out float valRetournee)
        {
            string valSaisie;
            bool retConv;
            do
            {
                Console.WriteLine(msgInfo);
                valSaisie = Console.ReadLine();
                retConv = float.TryParse(valSaisie, out valRetournee);
                if (retConv == false || borneSup < borneInf)
                {
                    Console.WriteLine(msgErreur);
                }
            } while (retConv == false || borneSup < borneInf);
        }
    }
}

