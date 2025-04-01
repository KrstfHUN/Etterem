using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Vendeg
    {
        public string Nev { get; set; }
        public List<Rendeles> Rendelesek { get; set; }
        public Vendeg(string nev)
        {
            Nev = nev;
            Rendelesek = new List<Rendeles>();
        }
        public void Rendel(MenuElem menuElem)
        {
            Rendelesek.Add(new Rendeles(menuElem));
        }

        public void Fizetes(Rendeles rendeles)
        {
            int osszeg = 0;
            foreach (Rendeles r in Rendelesek)
            {
                osszeg += r.MenuElem.Ar;
            }
            Console.WriteLine("Fizetett összeg: " + osszeg);
            Rendelesek.Remove(rendeles);
        }

    }
}
