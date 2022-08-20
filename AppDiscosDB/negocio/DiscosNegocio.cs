using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using negocio;

namespace negocio
{
    public class DiscosNegocio
    {
        public List<Discos> listar()
        {
            List<Discos> lista = new List<Discos>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT Titulo, FechaLanzamiento, UrlImagenTapa, CantidadCanciones, T.Descripcion DescripcionEstilo, E.Descripcion DescripcionEdicion  " +
                "from DISCOS D, ESTILOS T, TIPOSEDICION E where D.IdEstilo = T.Id AND E.Id = D.IdTipoEdicion";


                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.TiposEstilos = new Estilo();
                    aux.TiposEstilos.Descripcion = (string)lector["DescripcionEstilo"];
                    aux.TiposEdicion = new Edicion();
                    aux.TiposEdicion.Descripcion = (string)lector["DescripcionEdicion"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into DISCOS (Titulo, FechaLanzamiento, CantidadCanciones, UrlImagenTapa, IdEstilo, IdTipoEdicion) values ('" + nuevo.Titulo + "', '" + nuevo.FechaLanzamiento + "','" + nuevo.CantidadCanciones + "', @urlImagenTapa, @idEstilo, @idTipoEdicion)");
                datos.setearParametro("@idEstilo", nuevo.TiposEstilos.Id);
                datos.setearParametro("@idTipoEdicion", nuevo.TiposEdicion.Id);
                datos.setearParametro("@urlImagenTapa", nuevo.UrlImagenTapa);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Discos modificar)
        {

        }
    }
}
