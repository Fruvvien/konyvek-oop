using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek_oop
{
    internal class Szerzo
    {
        private string Nev { get; set; }
        private string Nemzetiseg { get; set; }

        public Szerzo(string nev, string nemzetiseg) 
        {
            Nev = nev;
            Nemzetiseg = nemzetiseg;
        
        }
        public override string ToString()

        {
            return Nev + " " + Nemzetiseg;
        }



    }
}
