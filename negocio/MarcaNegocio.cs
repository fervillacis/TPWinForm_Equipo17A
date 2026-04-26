using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Negocio;

namespace Negocio
{
    public class MarcaNegocio
    {
        List<Marca> marcas = new List<Marca>();
        AccesoDatos datos = new AccesoDatos();

        public List<Marca> listarMarcas()
        {
            try
            {
                datos.setearConsulta("select Id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    marcas.Add(aux);
                }

                return marcas;
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

        public void agregar(Marca nuevo)
        {
            try
            {

                datos.setearConsulta("insert into MARCAS(Descripcion) values(@Descripcion)");
                datos.setearParametro("@Descripcion", nuevo.Descripcion);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }

        }
        public void modificar(Marca modificado)
        {
            try
            {
                datos.setearConsulta("UPDATE MARCAS SET Descripcion = @Descripcion where id = @Id");
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

        public void eliminar(int id)
        {

            try
            {
                datos.setearConsulta("delete from MARCAS where Id = @Id");
                datos.setearParametro("@Id", id);

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
