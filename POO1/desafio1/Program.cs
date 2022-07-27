using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Telefono t1 = new Telefono("K6","Samsung");

            Console.WriteLine("Ingrese los datos del teléfono");
            Console.WriteLine("modelo: ");
            t1.Modelo = Console.ReadLine();
            Console.WriteLine("marca: ");
            t1.Marca = Console.ReadLine();
            Console.WriteLine("Nro de teléfono: ");
            t1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Código: ");
            t1.CodigoOperador = int.Parse(Console.ReadLine());

            
            Console.WriteLine(t1.llamar());            
            Console.WriteLine(t1.llamar("Marina"));

            Console.ReadKey();


        }
    }
}
