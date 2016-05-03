using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFilm
{
    public class Film
    {
        private string titre;
        private int nombreEnfant;
        private int nombreAdulte;

        public string GetTitre()
        {
            return titre;
        }

        public int GetNombreEnfant()
        {
            return nombreEnfant;
        }

        public int GetNombreAdulte()
        {
            return nombreAdulte;
        }

        public void SetTitre(string unTitre)
        {
            titre = unTitre;
        }

        public void SetNombreEnfant(int unNombreEnfant)
        {
            nombreEnfant = unNombreEnfant;
        }

        public void SetNombreAdulte(int unNombreAdulte)
        {
            nombreAdulte = unNombreAdulte;
        }

        public Film(string sonTiTre, int sonNombreEnfant, int sonNombreAdulte)
        {
            titre = sonTiTre;
            nombreEnfant = sonNombreEnfant;
            nombreAdulte = sonNombreAdulte;
        }

        public int NombreEntrees()
        {
            int totalEntres;

            totalEntres = nombreEnfant + nombreAdulte;
            return totalEntres;
        }

        public bool AucuneEntree()
        {
            bool retConv;

            if (nombreEnfant == 0 && nombreAdulte == 0)
            {
                retConv = true;

                
            }

            else
            {
                retConv = false;
            }
            return retConv;
        }

        public float Recette()
        {
            float prixEnfant;
            float prixAdulte;
            float prixTotal;

            prixEnfant = nombreEnfant * 4;
            prixAdulte = nombreAdulte * 5.5F;
            prixTotal = prixEnfant + prixAdulte;

            return prixTotal;
            
        }
        
        public bool AEuPlusdEntree(int nb)
        {
            int EntreeTotal;
            bool retConv;

            EntreeTotal = nombreAdulte + nombreEnfant;
            if (nb < EntreeTotal)
            {
                retConv = true;
            }

            else
            {
                retConv = false;
            }
            return retConv;
        }      
        
            
    }
}
