using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Vehiculo > Auto > AutoDeportivo > AutoUrbano
            // > Camioneta
            // > Moto

            Vehiculo v1 = new Vehiculo();
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();
            c1.Color = "Amarillo";
            c2.Color = "Rojo";
            c3.Color = "Blanco";

            //Vehiculo v2 = new Auto();
            //Camioneta c2 = new Vehiculo();
            //Esto no me deja hacerlo xq la herencia siempre es de abajo hacia arriba. 
            // Una camioneta ES un vehiculo pero Vehiculo no conoce a "Camioneta". 
            // Vehiculo puede ser moto, auto, etc.

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            Console.WriteLine("La cantidad de camionetas es de: " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "Negro";
            //c2.Color = "Verde";
            Console.WriteLine("El color de la camioneta es: " + listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            Console.WriteLine("La cantidad de camionetas es de: " + listaCamionetas.Count);

            foreach (Camioneta camioneta in listaCamionetas)
            {
                Console.WriteLine("Los colores de las camionetas son: " + camioneta.Color);
            }

            Auto a1 = new Auto();
            a1.Motor = new Motor();

            Console.ReadKey();

        }
    }
}
