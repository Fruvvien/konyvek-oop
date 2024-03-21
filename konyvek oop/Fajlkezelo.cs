using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konyvek_oop
{
    internal class Fajlkezelo
    {
        static List<Konyv> konyvLista = new List<Konyv>();

        public List<Konyv>  KonyvekBeolvasasFajlbol(string fajlnev) 
        {
           
            try
            {
                StreamReader sr = new StreamReader(fajlnev);
                while (!sr.EndOfStream)
                {
                    string line =  sr.ReadLine();
                    string[] array = line.Split(';');
                    konyvLista.Add(new Konyv(array[0], array[1], new Szerzo(array[2], array[3])));
                }
                return konyvLista;

            }catch (Exception ex) 
            {   
                Console.WriteLine(ex.ToString());
                return konyvLista;
                
            }
            
           
        }

    }
}
