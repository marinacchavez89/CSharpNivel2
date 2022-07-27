using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de productos, cada producto tiene:
            // - Código de articulo (3 digitos no correlativos)
            // - Precio
            // - Código de marca (1 a 10)
            // Segundo lote con las ventas de la semana. Cada venta tiene:
            // - Código de articulo
            // - Cantidad
            // - Código de cliente (1 a 100)
            // El lote corta con Código de Cliente cero.

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {   
                articulos[x] = new Articulo();

                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Código:");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Marca de 1 a 10:");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());
            }
            // Hasta aqui esta cargado el vector con los 10 articulos.

            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Ingrese código de cliente");
            venta.CodigoCliente = int.Parse(Console.ReadLine());            

            while (venta.CodigoCliente != 0)
            {
               
                Console.WriteLine("Ingrese articulo:");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                // trabajamos.

                // pido cliente nuevamente:
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Ingrese código de cliente");
                venta.CodigoCliente = int.Parse(Console.ReadLine());

            }

        }
    }
}
