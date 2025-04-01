using Etterem;

namespace EttermiRendszer_Doga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ettereme etterem = new Ettereme();
            etterem.Menu = Fajlkezelo.MenuBetoltese();

            Vendeg vendeg1 = new Vendeg("Kiss Péter");

            MenuElem burger = new MenuElem("Sajtburger", 1500, "Étel");
            MenuElem cola = new MenuElem("Kóla", 500, "Ital");

            etterem.HozzaadMenu(burger);
            etterem.HozzaadMenu(cola);

            etterem.ListazMenut();

            vendeg1.Rendel(burger);
            vendeg1.Rendel(cola);

            etterem.UjRendeles(vendeg1);

            Fajlkezelo.MenuMentese(etterem.Menu);
            Fajlkezelo.RendelesMentese(etterem.Rendelesek);
        }
    }
}