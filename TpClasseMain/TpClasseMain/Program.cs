using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpClasseMain
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantite;

            TpClassLib.saisie.SaisieNumerique("Veuillez saisir une quantité : ", out quantite);
        }
    }
}
