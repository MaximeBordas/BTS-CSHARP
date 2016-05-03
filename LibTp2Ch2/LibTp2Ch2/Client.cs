using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTp2Ch2
{
    public class Client
    {
        private int numClient;
        private string nomClient;
        private string villeClient;
        private int distanceClient;

        public int GetNumClient()
        {
            return numClient;
        }

        public string GetnNomClient()
        {
            return nomClient;
        }

        public string GetVilleClient()
        {
            return villeClient;
        }

        public int GetDistanceClient()
        {
            return distanceClient;
        }

        public void SetNumClient(int leNumClient)
        {
            numClient = leNumClient;
        }

        public void SetNomClient (string leNomClient)
        {
            nomClient = leNomClient;
        }

        public void SetVilleClient (string laVilleClient)
        {
            villeClient = laVilleClient;
        }

        public void SetDistanceClient(int laDistanceClient)
        {
            distanceClient = laDistanceClient;
        }
    }
}
