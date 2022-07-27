using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "PEPE";

            Gato g1 = new Gato();
            g1.Nombre = "Martina";

            Perro p1 = new Perro();
            p1.Nombre = "Sofía";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            List<IFlyable> listaVoladores = new List<IFlyable>();
            listaVoladores.Add(new Canario());
            listaVoladores.Add(new Canario());
            //Le puedo agregar que pueda volar.

            //foreach (Animal item in animales)
            //{
            //    Console.WriteLine(item.comunicarse());
            //}         



            Console.ReadKey();

        }
    }
}
