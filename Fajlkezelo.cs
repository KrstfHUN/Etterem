using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Fajlkezelo
    {
        private static string rendelesFile = "rendelesek.txt";
        private static string menuFile = "menu.txt";

        public static void RendelesMentese(List<MenuElem> menu)
        {
            using (var sw = new StreamWriter(menuFile))
            {
                foreach (var menuElem in menu)
                {
                    sw.WriteLine(menuElem.Nev + ";" + menuElem.Ar + ";" + menuElem.Kategoria);
                }
            }
            Console.WriteLine("Menü mentve!");
        }

        public static List<MenuElem> MenuBetoltese()
        {
            List<MenuElem> menu = new List<MenuElem>();
            if (!File.Exists(menuFile)) return menu;

            foreach (var sor in File.ReadAllLines(menuFile))
            {
                var adatok = sor.Split(';');
                var menuElem = new MenuElem(adatok[0], int.Parse(adatok[1]), adatok[2]);
                menu.Add(menuElem);
            }
            return menu;
        }

        public static void MenuMentese(List<MenuElem> menu)
        {
            using (var sw = new StreamWriter(menuFile))
            {
                foreach (var menuElem in menu)
                {
                    sw.WriteLine(menuElem.Nev + ";" + menuElem.Ar + ";" + menuElem.Kategoria);
                }
            }
            Console.WriteLine("Menü mentve!");
        }

        public static void MenuMentese(List<Rendeles> rendelesek)
        {
            using (var sw = new StreamWriter(rendelesFile))
            {
                foreach (var rendeles in rendelesek)
                {
                    sw.WriteLine(rendeles.Vendeg.Nev + ";" + rendeles.MenuElem.Nev + ";" + rendeles.MenuElem.Ar + ";" + rendeles.MenuElem.Kategoria);
                }
            }
            Console.WriteLine("Rendelések mentve!");
        }
    }
}
