using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibClassInClass
{
    public class Prestation
    {
        private string objetPrestation;
        private int nbJoursPrestation;
        private string numSirenExploitation;

        public string GetObjetPrestation()
        {
            return objetPrestation;
        }

        public void SetObjetPresentation(string unObjet)
        {
            objetPrestation = unObjet;
        }

        public int GetNbJoursPrestation()
        {
            return nbJoursPrestation;
        }
    }
}
