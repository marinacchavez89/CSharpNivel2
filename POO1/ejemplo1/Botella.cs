using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {   
        //capacidad máxima 100.
        //cantidadActual: inicia en cero.
        //método recarga: carga al 100 y devuelve el costo a recargar. 50 cada 100.

        // CONSTRUCTOR
        public  Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        // Se puede sobrecargar el constructor:

        public Botella() { }

        // Así se escribiria un destructor. Se ejecuta luego del garbage collector(que 
        //va limpiando la memoria que ya no se utiliza):

        ~Botella()
        {
            //acá irían los procesos que necesite.
        }

        // Botella: Capacidad, Color, Material.

        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        public string Material
        {
            get { return material; }
        }

        //PROPIEDAD

        //public int Capacidad
        //{
        //    get { return capacidad; }
        //   set { capacidad = value; }
        //}

        // MÉTODOS

        public float recargar()
        {   
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }

    
}
