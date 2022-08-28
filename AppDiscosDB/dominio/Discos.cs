using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Discos
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }

        [DisplayName("Cantidad de canciones")]
        public int CantidadCanciones { get; set; }

        public string UrlImagenTapa { get; set;}

        [DisplayName("Tipo de estilo")]
        public Estilo TiposEstilos { get; set; }

        [DisplayName("Tipo de edición")]
        public Edicion TiposEdicion { get; set; }
    }
}
