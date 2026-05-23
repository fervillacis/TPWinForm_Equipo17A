using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        List<Categoria> categorias = new List<Categoria>();
        AccesoDatos datos = new AccesoDatos();
        public List<Categoria> listarCategorias()

        {
            try
            {
                datos.setearConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    categorias.Add(aux);

                }

                return categorias;

            }
            catch (Exception ex)
            {

                throw new ApplicationException("Error al obtener el listado de categorías desde la base de datos.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void eliminar(int id)
        {

            try
            {
                datos.setearConsulta("delete from CATEGORIAS where Id = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al intentar eliminar la categoría con ID {id} de la base de datos.", ex);
            }
            finally { datos.cerrarConexion(); }

        }
        public void modificar(Categoria modificado)
        {
            try
            {
                datos.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @Descripcion where id = @Id");
                datos.setearParametro("@Id", modificado.Id);
                datos.setearParametro("@Descripcion", modificado.Descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al intentar modificar la categoría '{modificado.Descripcion}' (ID {modificado.Id}).", ex);

            }
            finally { datos.cerrarConexion(); }

        }
        public void agregar(Categoria nuevo)
        {
            try
            {

                datos.setearConsulta("insert into CATEGORIAS(Descripcion) values(@Descripcion)");
                datos.setearParametro("@Descripcion", nuevo.Descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al intentar agregar la categoría '{nuevo.Descripcion}' en la base de datos.", ex);

            }
            finally { datos.cerrarConexion(); }

        }
        public bool validarEliminarCategoria(int idCategoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE IdCategoria = @idCategoria");
                datos.setearParametro("@idCategoria", idCategoria);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int cantidad = (int)datos.Lector[0];
                    return cantidad > 0;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Error al validar dependencias de artículos para la categoría con ID {idCategoria}.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
