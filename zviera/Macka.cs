using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zviera
{
    class Macka : Zviera
    {
        public Macka(string meno, string druh, string farba, string specialnyZnak, int pocetNoh, int vek, bool srst) : base(meno, druh, farba, specialnyZnak, pocetNoh, vek, srst)
        {
        }
        new public void VydajZvuk()
        {
                Console.WriteLine("Mnau!");
                   }
    }
}
