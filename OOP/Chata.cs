﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Chata : Dom
    {
        private string spolocenskaMiestnost;
        public Chata(string nazov, string typ, string poschodie, int obytneMiestnsti, float uzitkovaPlocha, float zastavanaPlocha, string spolocenskaMiestnost) :base(nazov,typ,poschodie,obytneMiestnsti,uzitkovaPlocha,zastavanaPlocha)
        {
            this.spolocenskaMiestnost = spolocenskaMiestnost;
        }
        public void PopisChaty()
        {
            Console.WriteLine("Spolocenska miestnost: {0}", spolocenskaMiestnost);
        }
    }
}
