using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zviera
{
    class Program
    {
        static void Main(string[] args)
        {
            Zviera obecneZviera = new Zviera("meno zvierata", "druh zvierata", "farba zvierata", "specialny znak zvierata", 2, 1, true);
            obecneZviera.VydajZvuk();

            Macka cica = new Macka("Cica", "cicavec", "cierna", "biely nos", 4, 3, true);
            cica.VydajZvuk();

            Pes punto = new Pes("Punto", "cicavec", "hneda", "nema lave ucho", 4, 6, true);
            punto.VydajZvuk();

            Console.ReadKey();
        }
    }
}
