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
        public frmAgregarArticulo()
        {
            InitializeComponent();
        }

        public frmAgregarArticulo(Articulo articulo)
        {
            //Llamar este constructor para el boton modificar
            InitializeComponent();
            this.articulo = articulo;
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
            }
        }

        private void lblCodigoAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoAgregarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNombreAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreAgregarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDescripcionAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionAgregarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPrecioAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecioAgregarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUrlImagenAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtUrlImagenAgregarArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCategoriaAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cboCategoriasAgregarArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMarcasAgregarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cboMarcasAgregarArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptarArticuloAgregarArticulo_Click(object sender, EventArgs e)
            {
                Articulo articulo = new Articulo();
                ArticuloNegocio negocio = new ArticuloNegocio();
                try
                {
                    articulo.Codigo = txtCodigoAgregarArticulo.Text;
                    articulo.Nombre = txtNombreAgregarArticulo.Text;
                    articulo.Descripcion = txtDescripcionAgregarArticulo.Text;
                    articulo.Precio = decimal.Parse(txtPrecioAgregarArticulo.Text);
                    articulo.Marca = (Marca)cboMarcasAgregarArticulo.SelectedItem;
                    articulo.Categoria = (Categoria)cboCategoriasAgregarArticulo.SelectedItem;

                    //HACER LAS FUNCIONES EN ARTICULONEGOCIO PARA AGREGAR A LA DB   
                    negocio.agregar(articulo);
                    MessageBox.Show("Agregado exítosamente");
                    Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
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

        }

        private void btnQuitarImagenAgregarArticulo_Click(object sender, EventArgs e)
        {

        }
    }
}
