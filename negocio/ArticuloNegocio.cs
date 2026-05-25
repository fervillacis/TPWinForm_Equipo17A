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
        public int agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            int idGenerado = 0;

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) OUTPUT INSERTED.Id VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@Precio", nuevo.Precio);

                datos.ejecutarLectura();

                if (datos.Lector.Read())
                    idGenerado = Convert.ToInt32(datos.Lector[0]);

                return idGenerado;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al agregar el artículo.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void guardarImagen(int idArticulo, string urlImagen)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.setearParametro("@ImagenUrl", urlImagen);

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

        public void guardarImagenes(int idArticulo, List<string> imagenes)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @IdArticulo");
                datos.setearParametro("@IdArticulo", idArticulo);
                datos.ejecutarAccion();
                datos.cerrarConexion();

                foreach (string imagen in imagenes)
                {
                    if (!string.IsNullOrWhiteSpace(imagen))
                    {
                        AccesoDatos datosImagen = new AccesoDatos();
                        datosImagen.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@IdArticulo, @ImagenUrl)");
                        datosImagen.setearParametro("@IdArticulo", idArticulo);
                        datosImagen.setearParametro("@ImagenUrl", imagen);
                        datosImagen.ejecutarAccion();
                        datosImagen.cerrarConexion();
                    }
                }
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

            }
            catch (Exception ex)
            {
                throw new ApplicationException($"Ocurrió un error al intentar modificar los datos del artículo con ID {modificar.Id} en la base de datos.", ex);

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
                datos.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdCategoria, A.IdMarca, I.ImagenUrl, C.Descripcion AS Categoria, M.Descripcion AS Marca FROM ARTICULOS AS A INNER JOIN CATEGORIAS AS C ON A.IdCategoria = C.Id INNER JOIN MARCAS AS M ON A.IdMarca = M.Id OUTER APPLY (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id ORDER BY Id) AS I;");
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
                throw new ApplicationException("Error al consultar la lista completa de artículos desde la base de datos.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, A.IdCategoria, A.IdMarca, I.ImagenUrl, C.Descripcion AS Categoria, M.Descripcion AS Marca FROM ARTICULOS A INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id INNER JOIN MARCAS M ON A.IdMarca = M.Id OUTER APPLY (SELECT TOP 1 ImagenUrl FROM IMAGENES WHERE IdArticulo = A.Id ORDER BY Id) AS I WHERE ";

                if (campo == "Código")
                {
                    if (criterio == "Contiene")
                        consulta += "A.Codigo LIKE '%" + filtro + "%'";
                    else
                        consulta += "A.Codigo = '" + filtro + "'";
                }
                else if (campo == "Nombre")
                {
                    if (criterio == "Contiene")
                        consulta += "A.Nombre LIKE '%" + filtro + "%'";
                    else
                        consulta += "A.Nombre = '" + filtro + "'";
                }
                else if (campo == "Descripción")
                {
                    if (criterio == "Contiene")
                        consulta += "A.Descripcion LIKE '%" + filtro + "%'";
                    else
                        consulta += "A.Descripcion = '" + filtro + "'";
                }
                else if (campo == "Marca")
                {
                    if (criterio == "Contiene")
                        consulta += "M.Descripcion LIKE '%" + filtro + "%'";
                    else
                        consulta += "M.Descripcion = '" + filtro + "'";
                }
                else if (campo == "Categoría")
                {
                    if (criterio == "Contiene")
                        consulta += "C.Descripcion LIKE '%" + filtro + "%'";
                    else
                        consulta += "C.Descripcion = '" + filtro + "'";
                }
                else if (campo == "Precio")
                {
                    if (criterio == "Mayor a")
                        consulta += "A.Precio > " + filtro;
                    else if (criterio == "Menor a")
                        consulta += "A.Precio < " + filtro;
                    else
                        consulta += "A.Precio = " + filtro;
                }

                datos.setearConsulta(consulta);
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
                throw new ApplicationException("Error al filtrar artículos.", ex);
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
                throw new ApplicationException($"Error al intentar eliminar el artículo con ID {id} de la base de datos.", ex);
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
                throw new ApplicationException($"Error al consultar las imágenes asociadas al artículo con ID {idArticulo}.", ex);
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

        public bool existeCodigo(string codigo, int idArticulo = 0)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Verifico si existe otro artículo con el mismo código, excluyendo el artículo actual
                datos.setearConsulta("SELECT COUNT(*) FROM ARTICULOS WHERE Codigo = @Codigo AND Id <> @Id");
                datos.setearParametro("@Codigo", codigo);
                datos.setearParametro("@Id", idArticulo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    int cantidad = Convert.ToInt32(datos.Lector[0]);
                    return cantidad > 0;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Error al validar la duplicidad del código en la base de datos.", ex);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
