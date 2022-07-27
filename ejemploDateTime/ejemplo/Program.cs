using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime fecha = DateTime.Now;

            Console.WriteLine("La fecha es: " + fecha.ToString("dd/MM/yyyy"));

            Console.ReadKey();
        }
    }
}
