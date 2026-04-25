using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();


        public void agregar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, Precio) values (@Codigo, @Nombre, @Descripcion, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion); 
                //datos.setearParametro("@ImagenUrl", nuevo.UrlImagen); NO ESTA EN LA DB, HAY QUE GENERAR CLASE IMAGEN
                datos.setearParametro("@Precio", nuevo.Precio);

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
