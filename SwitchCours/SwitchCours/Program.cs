using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCours
{
    class Program
    {
        static void Main(string[] args)
        {
            switch (CategClient)
            {
                case 'G';
                    montantApayer = montantApayer - montantApayer * 5 / 100;
                    break;
                case 'C';
                    montantApayer = montantApayer - montantApayer * 7 / 100;
                    break;
                case 'D';
                    montantApayer = montantApayer - montantApayer * 10 / 100;
            }
        }
    }
}
