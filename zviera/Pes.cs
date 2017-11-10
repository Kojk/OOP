using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zviera
{
    class Pes : Zviera
    {
        
        public Pes(string meno, string druh, string farba, string specialnyZnak, int pocetNoh, int vek, bool srst) : base(meno, druh, farba, specialnyZnak, pocetNoh, vek, srst)
        
        {
          
        }
        public override void VydajZvuk()
        {
            Console.WriteLine("Haf!");
        }
        public override void NakrmZviera() 
        {
            nakrmen = true;
        }
    }
}
