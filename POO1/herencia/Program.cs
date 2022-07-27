using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Persona > Lider > Developer > Tester
            Persona p1 = new Persona();
            Developer d1 = new Developer();

            //Lider l1 = new Lider();
            Lider.algo();

            //Por ej Console es una clase estatica:

            Console.WriteLine("Hola...");

        }
    }
}
