using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{   
    // Las clases pueden ser abstract , sealed o static.  --> La static me permite
    //poder usar la clase sin tener que instanciarla
     class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }

    }
}
