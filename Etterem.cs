using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    internal class Etterem
    {
        internal List<MenuElem> Rendelesek;

        public List<MenuElem> Menu { get; set; }

        public Etterem()
        {
            Menu = new List<MenuElem>();
        }

        public void HozzaadMenu(MenuElem menuElem)
        {
            Menu.Add(menuElem);
        }

        public void ListazMenut()
        {
            foreach (MenuElem menuElem in Menu)
            {
                Console.WriteLine(menuElem.Nev + " " + menuElem.Ar + " " + menuElem.Kategoria);
            }
        }

        public void UjRendeles(Vendeg vendeg)
        {
            foreach (Rendeles rendeles in vendeg.Rendelesek)
            {
                Console.WriteLine(vendeg.Nev + " rendelése: " + rendeles.MenuElem.Nev);
            }
            vendeg.Fizetes(vendeg.Rendelesek[0]);
        }
    }
}
