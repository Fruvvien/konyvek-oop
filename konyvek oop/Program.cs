using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Fajlkezelo fajlkezelo = new Fajlkezelo();

            List<Konyv> konyvlist = fajlkezelo.KonyvekBeolvasasFajlbol("konyvek.txt");
            
            foreach(Konyv v in konyvlist)
            {
                Console.WriteLine(v);
            }

        }
    }
}
