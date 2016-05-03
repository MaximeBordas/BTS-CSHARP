using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibAnimalerie;

namespace Animalerie
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal unAni;
            Animal unAni2;
            Animal unAni3;

            unAni = new Animal("Nemo", "poisson rouge", "Gloup" ,12);
            unAni2 = new Animal("Felix", "chat", "Miaou",24);
            unAni3 = new Animal("Titi", "canari", "Cui", 36);

            unAni.SePresenter();
            unAni.Parler();
            unAni.Parler(4);
            unAni.Manger();
            unAni.Dormir();
            Console.ReadLine();
        }
    }
}
