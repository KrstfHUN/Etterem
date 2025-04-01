using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Rendeles
    {
        public MenuElem MenuElem { get; set; }
        public Vendeg Vendeg { get; set; }
        public Rendeles(MenuElem menuElem)
        {
            MenuElem = menuElem;
        }

        public void Fizetes()
        {
            Vendeg.Fizetes(this);
        }
    }
}
