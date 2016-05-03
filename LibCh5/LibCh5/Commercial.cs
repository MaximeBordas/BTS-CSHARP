using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCh5
{
    class Commercial:Employe
    {
        private float txCommision;
        private float mtCa;

        public float GetTxCom()
        {
            return txCommision;
        }

        public float GetMtCa()
        {
            return mtCa;
        }

        public float GetMtCom()
        {
            return this.GetMtCa() * this.GetTxCom() / 100;
        }

        public void SetTxCom(float TxCom)
        {
            this.txCommision = TxCom;
        }

        public void AugmentVente( float montant)
        {
            mtCa = mtCa = montant;
        }
        public Commercial(string unMatricule, string unNom, float unSalaireMensuel, string unDiplome, float unTxCom, float unCa) : base(unMatricule,unNom,unSalaireMensuel,unDiplome)
        {
            this.txCommision = unTxCom;
            this.mtCa = unCa;
        }
    }
}
