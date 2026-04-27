using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using System.Data.SqlClient;

namespace Negocio
{
    public class ArticuloNegocio
    {
        private AccesoDatos datos = new AccesoDatos();

        //    AGREGAR
        public void agregar(Articulo nuevo)
        {
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);
                datos.setearParametro("@IdArticulo", nuevo.Id);

                datos.ejecutarAccion();
                datos.cerrarConexion();

                var datos2 = new AccesoDatos();
                datos2.setearConsulta("SELECT SCOPE_IDENTITY()");
                datos2.ejecutarLectura();
                if (datos2.Lector.Read() && !Convert.IsDBNull(datos2.Lector[0]))
                    nuevo.Id = Convert.ToInt32(datos2.Lector[0]);
                datos2.cerrarConexion();

                // Insertar imagen vinculada (solo si hay URL)
                if (!string.IsNullOrEmpty(nuevo.ImagenUrl))
                {
                    var datos3 = new AccesoDatos();
                    datos3.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                    datos3.setearParametro("@IdArticulo", nuevo.Id);
                    datos3.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                    datos3.ejecutarAccion();
                    datos3.cerrarConexion();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        //     MODIFICAR
        public void modificar(Articulo modificar)
        {
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio where id = @Id");
                datos.setearParametro("@Id", modificar.Id);
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@IdMarca", modificar.Marca.Id);
                datos.setearParametro("@IdCategoria", modificar.Categoria.Id);
                datos.setearParametro("@Precio", modificar.Precio);

                datos.ejecutarAccion();
                datos.cerrarConexion();

                if (!string.IsNullOrEmpty(modificar.ImagenUrl))
                {
                    // Intentar actualizar la imagen
                    var datos2 = new AccesoDatos();
                    datos2.setearConsulta("UPDATE IMAGENES SET ImagenUrl=@ImagenUrl WHERE IdArticulo=@IdArticulo");
                    datos2.setearParametro("@IdArticulo", modificar.Id);
                    datos2.setearParametro("@ImagenUrl", modificar.ImagenUrl);
                    datos2.ejecutarAccion();
                    datos2.cerrarConexion();

                    // Verificar si la imagen existe
                    var datos3 = new AccesoDatos();
                    datos3.setearConsulta("SELECT COUNT(*) FROM IMAGENES WHERE IdArticulo=@IdArticulo");
                    datos3.setearParametro("@IdArticulo", modificar.Id);
                    datos3.ejecutarLectura();
                    bool existe = false;
                    if (datos3.Lector.Read() && Convert.ToInt32(datos3.Lector[0]) > 0)
                        existe = true;
                    datos3.cerrarConexion();

                    // Si no existía, insertamos
                    if (!existe)
                    {
                        var datos4 = new AccesoDatos();
                        datos4.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                        datos4.setearParametro("@IdArticulo", modificar.Id);
                        datos4.setearParametro("@ImagenUrl", modificar.ImagenUrl);
                        datos4.ejecutarAccion();
                        datos4.cerrarConexion();
                    }
                }


            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }
        }

        //     LISTAR
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion,A.Precio, A.IdCategoria, A.IdMarca, I.ImagenUrl, C.Descripcion AS Categoria, M.Descripcion AS Marca FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id INNER JOIN MARCAS AS M ON A.IdMarca = M.Id LEFT JOIN IMAGENES AS I ON I.IdArticulo = A.Id;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];


                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("Precio"))))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    if (!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("ImagenUrl"))))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];


                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];


                    lista.Add(aux);
                }

                return lista;
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

        // ELIMINAR

        public void eliminar(int id)
        {
            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }

        public List<Imagen> getImagenes(int idArticulo) // funcion para las imganes de la lista
        {
            List<Imagen> lista = new List<Imagen>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta($"select id,idArticulo, ImagenUrl from IMAGENES where IdArticulo={idArticulo}");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                    aux.Id = (int)datos.Lector["id"];
                    aux.IdArticulo = (int)datos.Lector["idArticulo"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];


                    lista.Add(aux);
                }

                return lista;
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

        public List<string> ObtenerImagenesPorId(int idArticulo)
        {
            var imagenes = new List<string>();
            var datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.setearParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var u = (datos.Lector["ImagenUrl"] as string)?.Trim();
                    if (!string.IsNullOrWhiteSpace(u))
                        imagenes.Add(u);
                }

                return imagenes;
            }
            catch (SqlException ex)
            {
                throw new ApplicationException("Error de base al listar imágenes del artículo.", ex);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error inesperado al listar imágenes del artículo.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
