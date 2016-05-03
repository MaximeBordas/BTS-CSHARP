using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCh5
{
    class Secretaire:Employe
    {
        private int niveauAnglais;

        public int GetNiveauAnglais()
        {
            return niveauAnglais;
        }

        public void SetNiveauAnglais(int leNiveauAnglais)
        {
            niveauAnglais = leNiveauAnglais;
        }

        public Secretaire(string unMatricule, string unNom, float unSalaireMensuel, string unDiplome, int unNiveauAnglais) : base(unMatricule, unNom, unSalaireMensuel, unDiplome)
        {
            this.niveauAnglais = unNiveauAnglais;
        }
    }
}
