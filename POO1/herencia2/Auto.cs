using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Auto : Vehiculo
    {   
        // Constructor (nace con ciertas caracteristicas)
        public Auto() 
        {
            Chasis = new Chasis();
        }
       
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }


        // Composición. (se tiene que si o si colocar en el constructor)
        public Chasis Chasis { get; }

        //Agregación. (se lo puedo agregar despúes del contructor.
        public Motor Motor { get; set; }

        //Las relaciones de herencia se leen con ES y la relacion de composición o agregación 
        //(asociación) se lee con TIENE.

    }
}
