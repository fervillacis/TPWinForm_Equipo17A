using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> listar() // devuelve lista de categorias 
        {
            List<Categoria> lista = new List<Categoria>(); // creo lista
            AccesoDatos accesoDatos = new AccesoDatos(); // creo objeto acceso a datos

            try
            {
                accesoDatos.setearConsulta("Select Id, Descripcion from CATEGORIAS"); // consulta a ejecutar
                accesoDatos.ejecutarLectura(); // ejecuta

                while (accesoDatos.Lector.Read())
                {
                    Categoria objetoCategoria = new Categoria();

                    objetoCategoria.Id = (int)accesoDatos.Lector["Id"]; // lee valor de columna indicada y lo guarda en el objeto auxiliar
                    objetoCategoria.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    lista.Add(objetoCategoria); // agrego el objeto auxiliar a la lista
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
