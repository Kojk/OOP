using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Activ 1", "aktivni", "nie", 3, 70.9f, 35.8f);
            mojDom.PoskytniInformace();
            Console.WriteLine("Percento zastavanej plochy je {0}% ", mojDom.ZistiVyuzitelnostZastavnejPlochy());

            Dom susedovDom = new Dom("Activ 2", "aktivni", "nie", 4, 100.9f, 35.8f);
            susedovDom.PoskytniInformace();
            Console.WriteLine("Percento zastavanej plochy je {0}% ", susedovDom.ZistiVyuzitelnostZastavnejPlochy());

            Chata chata = new Chata("Chata 1", "pasivna", "10", 50, 200.5f, 100, "ano je velka");
            chata.PoskytniInformace();
            Console.WriteLine("Percento zastavanej plochy je {0}% ", chata.ZistiVyuzitelnostZastavnejPlochy());
            chata.PopisChaty();


            Console.ReadLine();
        }
    }
}
