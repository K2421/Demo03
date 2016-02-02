using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class opiskelijat
    {
        //properties
        public string Nimi { get; set; }
        public string Opiskelijanro { get; set; }
        public double Ka { get; set; } // Keskiarvo
        public double Op { get; set; } // Suoritetut opintopisteet
        public int Aloitusv { get; set; } // Opintojen aloitusvuosi
      

        // methods
  
        // print properties to console
        public void PrintData()
        {
            Console.WriteLine("Opiskelijan tiedot:");
            Console.WriteLine("- Nimi: {0}", Nimi);
            Console.WriteLine("- Opiskelijanumero: {0}", Opiskelijanro);
            Console.WriteLine("- Keskiarvo: {0}", Ka);
            Console.WriteLine("- Suoritetut opintopisteet: {0}", Op);
            Console.WriteLine("- Opintojen aloitusvuosi: {0}", Aloitusv);
         
        }
    }
}

