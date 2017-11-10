using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zviera
{
    abstract class Zviera
    {
        protected string meno;
        protected bool nakrmen;
        private string druh, farba, specialnyZnak;
        private int pocetNoh, vek;
        private bool srst;
        public Zviera(string meno, string druh, string farba, string specialnyZnak, int pocetNoh, int vek, bool srst)
        {
            this.meno = meno;
            this.druh = druh;
            this.farba = farba;
            this.specialnyZnak = specialnyZnak;
            this.pocetNoh = pocetNoh;
            this.vek = vek;
            this.srst = srst;
        }
        public virtual void VydajZvuk()
        {
            Console.WriteLine("Toto je obecny zvuk zvierata"); 
        }
        public abstract void NakrmZviera();
    }
}
