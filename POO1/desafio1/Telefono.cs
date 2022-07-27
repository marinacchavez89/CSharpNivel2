using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }


        private string modelo;
        private string marca;
        private string numeroTelefonico;
        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador
        {
            get { return CodigoOperador; }
            set
            {
                if (codigoOperador > 0 && codigoOperador < 3)
                    codigoOperador = value;
                else codigoOperador = 0;
            }
        }

        public string llamar()
        {
            return "Realizando llamada...";
        }

        public string llamar(string contacto)
        {
            return "Reealizando llamada a " + contacto;
        }


    }
}
