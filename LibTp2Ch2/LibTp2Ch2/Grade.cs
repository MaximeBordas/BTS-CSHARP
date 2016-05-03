using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTp2Ch2
{
    public class Grade
    {
        private string libelleGrade;
        private float tauxGrade;

        public string GetLibelleGrade()
        {
            return libelleGrade;
        }

        public float GetNumClient()
        {
            return tauxGrade;
        }

        public void SetLibelleGrade(string leLibelleGrade)
        {
            libelleGrade = leLibelleGrade;
        }

        public void SetTauxGrade(float leTauxGrade)
        {
            tauxGrade = leTauxGrade;
        }
    }
}
