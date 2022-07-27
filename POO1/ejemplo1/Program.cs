using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona: Edad, Sueldo, Nombre.

            Persona p1 = new Persona("PEPE");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("Marina"));
            Console.WriteLine("La edad de la persona es " + p1.getEdad());

            Botella b1 = new Botella("Rojo", "Plástico");

            Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);
            Console.WriteLine("La cantidad de la botella es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad de la botella es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad de la botella es: " + b1.CantidadActual);

            //b1.Capacidad = 200;
            //Botella b2 = new Botella();
            // si le quiero guardar a algo la capacidad q tiene la botella, armo variable:
            //int algo = b1.Capacidad;

            Console.ReadKey();

        }
    }
}
