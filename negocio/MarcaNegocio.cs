using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> listar() 
        {
            List<Marca> lista = new List<Marca>(); 
            AccesoDatos accesoDatos = new AccesoDatos(); 

            try
            {
                accesoDatos.setearConsulta("Select Id, Descripcion from MARCAS"); 
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Marca objetoMarca = new Marca();

                    objetoMarca.Id = (int)accesoDatos.Lector["Id"];
                    objetoMarca.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    lista.Add(objetoMarca);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }


}

