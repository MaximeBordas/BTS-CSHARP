using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCh5
{
    public class Employe
    {
        private string matricule;
        private string nom;
        private float salaireMensuel;
        private string diplome;

        private void Augmenter (float augment)
        {
            salaireMensuel = salaireMensuel + augment;
        }

        public string GetMatricule()
        {
            return matricule;
        }

        public string GetNom()
        {
            return nom;
        }

        public float GetSalaireMensuel()
        {
            return salaireMensuel;
        }

        public string GetDiplome()
        {
            return diplome;
        }

        public void SetNom(string leNom)
        {
            nom = leNom;
        }

        public void SetDiplome(string leDiplome)
        {
            diplome = leDiplome;
        }

        public Employe (string unMatricule, string unNom, float unSalaireMensuel, string unDiplome)
        {
            this.matricule = unMatricule;
            this.nom = unNom;
            this.salaireMensuel = unSalaireMensuel;
            this.diplome = unDiplome;
        }
    }
}
