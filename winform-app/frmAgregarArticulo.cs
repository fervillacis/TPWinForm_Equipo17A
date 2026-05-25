using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAgregarArticulo : Form
    {
        Articulo articulo = null;
        List<string> imagenes = new List<string>();
        List<string> imagenesNuevas = new List<string>();
        int indiceImagenActual = 0;

        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            //Llamar este constructor para el boton modificar
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar articulo";
        }

        private void frmAgregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            cboCategoriasAgregarArticulo.DataSource = categoria.listarCategorias();
            cboCategoriasAgregarArticulo.ValueMember = "Id";
            cboCategoriasAgregarArticulo.DisplayMember = "Descripcion";
            cboMarcasAgregarArticulo.DataSource = marca.listarMarcas();
            cboMarcasAgregarArticulo.ValueMember = "Id";
            cboMarcasAgregarArticulo.DisplayMember = "Descripcion";


            if (articulo != null)
            {
                txtCodigoAgregarArticulo.Text = articulo.Codigo;
                txtNombreAgregarArticulo.Text = articulo.Nombre;
                txtDescripcionAgregarArticulo.Text = articulo.Descripcion;
                txtPrecioAgregarArticulo.Text = articulo.Precio.ToString();
                cboMarcasAgregarArticulo.SelectedValue = articulo.Marca.Id;
                cboCategoriasAgregarArticulo.SelectedValue = articulo.Categoria.Id;

                ArticuloNegocio negocio = new ArticuloNegocio();
                imagenes = negocio.ObtenerImagenesPorId(articulo.Id);

                if (imagenes.Count > 0)
                {
                    indiceImagenActual = 0;
                    MostrarImagenActual();
                }
            }
        }


        private void btnAceptarArticuloAgregarArticulo_Click(object sender, EventArgs e)
            {
            if (!validarCampos())
                return;
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigoAgregarArticulo.Text.Trim();
                articulo.Nombre = txtNombreAgregarArticulo.Text.Trim();
                articulo.Descripcion = txtDescripcionAgregarArticulo.Text.Trim();
                articulo.Precio = decimal.Parse(txtPrecioAgregarArticulo.Text);
                articulo.Marca = (Marca)cboMarcasAgregarArticulo.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoriasAgregarArticulo.SelectedItem;
            
                if (articulo.Id != 0)
                {
                    negocio.modificar(articulo);

                    if (!string.IsNullOrWhiteSpace(txtUrlImagenAgregarArticulo.Text))
                    {
                        string url = txtUrlImagenAgregarArticulo.Text.Trim();

                        if (!imagenes.Contains(url) && !imagenesNuevas.Contains(url))
                        {
                            imagenesNuevas.Add(url);
                        }
                    }

                    List<string> todas = new List<string>();
                    todas.AddRange(imagenes);
                    todas.AddRange(imagenesNuevas);

                    negocio.guardarImagenes(articulo.Id, todas);

                    MessageBox.Show("El artículo ha sido modificado con éxito.", "Artículo Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int idArticulo = negocio.agregar(articulo);

                    if (!string.IsNullOrWhiteSpace(txtUrlImagenAgregarArticulo.Text))
                    {
                        string url = txtUrlImagenAgregarArticulo.Text.Trim();

                        if (!imagenes.Contains(url) && !imagenesNuevas.Contains(url))
                        {
                            imagenesNuevas.Add(url);
                        }
                    }

                    foreach (string imagen in imagenesNuevas)
                    {
                        negocio.guardarImagen(idArticulo, imagen);
                    }

                    MessageBox.Show("El artículo ha sido registrado con éxito.", "Artículo Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error inesperado al procesar la información en la base de datos.", "Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelarArticuloAgregarArticulo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pbxArticuloAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarImagenAgregarArticulo_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtUrlImagenAgregarArticulo.Text))
            {
                imagenesNuevas.Add(txtUrlImagenAgregarArticulo.Text.Trim());

                indiceImagenActual = imagenes.Count + imagenesNuevas.Count - 1;
                MostrarImagenActual();
            }
        }

        private void btnQuitarImagenAgregarArticulo_Click(object sender, EventArgs e)
        {
            List<string> todas = new List<string>();
            todas.AddRange(imagenes);
            todas.AddRange(imagenesNuevas);

            if (todas.Count == 0)
                return;

            string imagenActual = todas[indiceImagenActual];

            if (imagenes.Contains(imagenActual))
                imagenes.Remove(imagenActual);

            if (imagenesNuevas.Contains(imagenActual))
                imagenesNuevas.Remove(imagenActual);

            todas.Clear();
            todas.AddRange(imagenes);
            todas.AddRange(imagenesNuevas);

            if (indiceImagenActual >= todas.Count)
                indiceImagenActual = todas.Count - 1;

            if (indiceImagenActual < 0)
                indiceImagenActual = 0;

            MostrarImagenActual();
        }

        private void MostrarImagenActual()
        {
            List<string> todas = new List<string>();
            todas.AddRange(imagenes);
            todas.AddRange(imagenesNuevas);

            if (todas.Count > 0)
            {
                try
                {
                    pbxArticuloAgregarArticulo.Load(todas[indiceImagenActual]);
                    txtUrlImagenAgregarArticulo.Text = todas[indiceImagenActual];
                }
                catch
                {
                    pbxArticuloAgregarArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
                }
            }
            else
            {
                pbxArticuloAgregarArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
                txtUrlImagenAgregarArticulo.Clear();
            }
        }

        private bool validarCampos()
        {
            // 1. Validar campos obligatorios vacíos
            if (string.IsNullOrWhiteSpace(txtCodigoAgregarArticulo.Text))
            {
                MessageBox.Show("El campo 'Código' es obligatorio. Por favor, ingréselo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoAgregarArticulo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNombreAgregarArticulo.Text))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio. Por favor, ingréselo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreAgregarArticulo.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrecioAgregarArticulo.Text))
            {
                MessageBox.Show("El campo 'Precio' es obligatorio. Por favor, ingréselo.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioAgregarArticulo.Focus();
                return false;
            }

            // 2. Validar formato numérico del precio (debe ser un decimal positivo o cero)
            decimal precio;
            if (!decimal.TryParse(txtPrecioAgregarArticulo.Text, out precio) || precio < 0)
            {
                MessageBox.Show("Por favor, ingrese un precio numérico válido (mayor o igual a cero).", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioAgregarArticulo.Focus();
                return false;
            }

            // 3. Validar duplicidad de código
            ArticuloNegocio negocio = new ArticuloNegocio();
            int idActual = (articulo != null) ? articulo.Id : 0;
            if (negocio.existeCodigo(txtCodigoAgregarArticulo.Text.Trim(), idActual))
            {
                MessageBox.Show("El código de artículo ingresado ya se encuentra registrado. Por favor, ingrese un código único.", "Código Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoAgregarArticulo.Focus();
                return false;
            }

            return true;
        }

        private void btnAnteriorImagenAgregarArticulo_Click(object sender, EventArgs e)
        {
            List<string> todas = new List<string>();
            todas.AddRange(imagenes);
            todas.AddRange(imagenesNuevas);

            if (todas.Count == 0)
                return;

            indiceImagenActual--;

            if (indiceImagenActual < 0)
                indiceImagenActual = todas.Count - 1;

            MostrarImagenActual();
        }

        private void btnSiguienteImagenAgregarArticulo_Click(object sender, EventArgs e)
        {
            List<string> todas = new List<string>();
            todas.AddRange(imagenes);
            todas.AddRange(imagenesNuevas);

            if (todas.Count == 0)
                return;

            indiceImagenActual++;

            if (indiceImagenActual >= todas.Count)
                indiceImagenActual = 0;

            MostrarImagenActual();
        }
    }
}
