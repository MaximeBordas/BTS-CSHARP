using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCh5
{
    class Reparateur:Employe
    {
        private float coutHoraire;

        public float GetCoutHoraire()
        {
            return coutHoraire;
        }

        public void SetCoutHoraire(float leCoutHoraire)
        {
            coutHoraire = leCoutHoraire;
        }

        public Reparateur(string unMatricule, string unNom, float unSalaireMensuel, string unDiplome, float unCoutHoraire) : base(unMatricule,unNom,unSalaireMensuel,unDiplome)
        {
            this.coutHoraire = unCoutHoraire;
        }
    }
}
