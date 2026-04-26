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

                throw ex;
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
                throw ex;
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
                throw ex;

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
                throw ex;

            }
            finally { datos.cerrarConexion(); }

        }

    }
}
