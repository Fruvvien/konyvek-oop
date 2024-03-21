using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace konyvek_oop
{
    internal class Konyv
    {
        private string Cim { get; set; }
        private string Mufaj { get; set; }
        private Szerzo Szerzo { get; set; }

        public Konyv(string cim, string mufaj, Szerzo szerzo) {
            this.Cim = cim;
            this.Mufaj = mufaj;
            this.Szerzo = szerzo;
        }

        
        public override string ToString()
        {
            return $"Könyv címe: {Cim} Műfaj: {Mufaj} Szerző: {Szerzo}";
        }


    }
}
