using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Canario : AnimalDomestico, IFlyable
    {
        public string volar()
        {
            return "Vuela como un canario...";
        }
    }
}
