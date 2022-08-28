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
                comando.CommandText = "SELECT Titulo, FechaLanzamiento, UrlImagenTapa, CantidadCanciones, T.Descripcion DescripcionEstilo, E.Descripcion DescripcionEdicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS T, TIPOSEDICION E where D.IdEstilo = T.Id AND E.Id = D.IdTipoEdicion";


                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Id = (int)lector["Id"];
                    aux.Titulo = (string)lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    //if (!(lector.IsDBNull(lector.GetOrdinal("UrlImagenTapa"))))
                    //    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    if (!(lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];
                    aux.TiposEstilos = new Estilo();
                    aux.TiposEstilos.Id = (int)lector["IdEstilo"];
                    aux.TiposEstilos.Descripcion = (string)lector["DescripcionEstilo"];
                    aux.TiposEdicion = new Edicion();
                    aux.TiposEdicion.Id = (int)lector["IdTipoEdicion"];
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

        public void modificar(Discos disc)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update DISCOS set Titulo = @titulo, FechaLanzamiento = @fechaLanzamiento, CantidadCanciones = @cantidadCanciones, UrlImagenTapa = @urlImagenTapa, IdEstilo = @idEstilo, IdTipoEdicion = @idTipoEdicion where Id = @id");
                datos.setearParametro("@titulo", disc.Titulo);
                datos.setearParametro("@fechaLanzamiento", disc.FechaLanzamiento);
                datos.setearParametro("@cantidadCanciones", disc.CantidadCanciones);
                datos.setearParametro("@urlImagenTapa", disc.UrlImagenTapa);
                datos.setearParametro("@idEstilo", disc.TiposEstilos.Id);
                datos.setearParametro("@idTipoEdicion", disc.TiposEdicion.Id);
                datos.setearParametro("@id", disc.Id);

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

        public List<Discos> filtrar(string campo, string criterio, string filtro)
        {   
            List<Discos> lista = new List<Discos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Titulo, FechaLanzamiento, UrlImagenTapa, CantidadCanciones, T.Descripcion DescripcionEstilo, E.Descripcion DescripcionEdicion, D.IdEstilo, D.IdTipoEdicion, D.Id from DISCOS D, ESTILOS T, TIPOSEDICION E where D.IdEstilo = T.Id AND E.Id = D.IdTipoEdicion AND ";
                if(campo == "Cantidad Canciones")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "CantidadCanciones > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "CantidadCanciones < " + filtro;
                            break;
                        default:
                            consulta += "CantidadCanciones = " + filtro;
                            break;
                    }
                }
                else if(campo == "Estilo")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "T.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "T.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "T.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "E.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "E.Descripcion like '%" + filtro + "'";
                            break;
                        default:
                            consulta += "E.Descripcion like '%" + filtro + "%'";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {   
                    Discos aux = new Discos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Titulo = (string)datos.Lector["Titulo"];
                    aux.FechaLanzamiento = (DateTime)datos.Lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)datos.Lector["CantidadCanciones"];                   
                    if (!(datos.Lector["UrlImagenTapa"] is DBNull))
                        aux.UrlImagenTapa = (string)datos.Lector["UrlImagenTapa"];
                    
                    aux.TiposEstilos = new Estilo();
                    aux.TiposEstilos.Id = (int)datos.Lector["IdEstilo"];
                    aux.TiposEstilos.Descripcion = (string)datos.Lector["DescripcionEstilo"];
                    aux.TiposEdicion = new Edicion();
                    aux.TiposEdicion.Id = (int)datos.Lector["IdTipoEdicion"];
                    aux.TiposEdicion.Descripcion = (string)datos.Lector["DescripcionEdicion"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void eliminar(int Id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from DISCOS where Id = @id ");
                datos.setearParametro("@id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
