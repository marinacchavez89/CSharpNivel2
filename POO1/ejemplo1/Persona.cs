using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        // Persona: Edad, Sueldo, Nombre.
        // ATRIBUTOS O MIEMBROS.
        private  int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //MÉTODOS

        public string saludar()
        {
            return "Hola, soy " + nombre;
        }

        // Sobrecarga de métodos
        public string saludar(string personaje)
        {
            return "Hola, " + personaje + " soy " + nombre;
        }

    }
}
