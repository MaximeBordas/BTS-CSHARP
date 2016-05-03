using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch4Test
{
    public static class TVA
    {
        static float tauxnormal;
        public static float TauxNormal
        {
            get { return TVA.tauxnormal; }
            set { TVA.tauxnormal = value; }
        }

        static float tauxreduit;

        public static float TauxReduit
        {
            get { return TVA.tauxreduit; }
            set { TVA.tauxreduit = value; }
        }
        static TVA()
        {
            string[] tabEnreg;//Tab utiliser dans la méthode split
            string enreg;
            StreamReader monFicher = null;
            try
            {
                monFicher = new StreamReader(@"C:\Users\Maxime\Desktop\tva.txt");

                enreg = monFicher.ReadLine();

                if (enreg == null)
                {
                    tauxnormal = 0;
                    tauxreduit = 0;
                }
                else
                {
                    while (enreg != null)
                    {
                        tabEnreg = enreg.Split(';');
                        if(tabEnreg[0]=="N")
                            float.TryParse(tabEnreg[1], out tauxnormal);
                        if(tabEnreg[0]=="R")
                            float.TryParse(tabEnreg[1], out tauxreduit);
                        enreg = monFicher.ReadLine();
                    }
                }
                monFicher.Close();
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Répertoire non trouvé");
            }
            catch (Exception err)
            {
                Console.WriteLine("Prblème de lecture du taux de TVA" + err.Message);
            }
            finally
            {
                if (monFicher != null) monFicher.Close();
            }
        }
            public static float CalculMontantTva(float ht,char typeTaux)
        {
            if (typeTaux == 'N')
                return (1 + tauxnormal / 100) * ht;
            else
                return (1 + tauxreduit / 100) * ht;
        }
        }
}
