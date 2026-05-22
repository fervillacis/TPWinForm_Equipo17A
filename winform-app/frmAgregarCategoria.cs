using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_app
{
    public partial class frmAgregarCategoria : Form
    {
        Categoria categoria = null;
        CategoriaNegocio negocio = new CategoriaNegocio();


        public frmAgregarCategoria()
        {
            InitializeComponent();
        }
        public frmAgregarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificar Categoria";
        }


        private bool validarNombreCategoria()
        {
            List<Categoria> lista = negocio.listarCategorias();

            if (string.IsNullOrEmpty(txtDescripcionCategoria.Text))
            {
                MessageBox.Show("Ingrese una descripción");
                return false;
            }

            foreach (Categoria cat in lista)
            {
                if (cat.Descripcion.ToLower() == txtDescripcionCategoria.Text.ToLower())
                {
                    MessageBox.Show("La categoría ya existe");
                    return false;
                }
            }

            return true;
        }
        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Descripcion = txtDescripcionCategoria.Text;

                if (validarNombreCategoria())
                {
                    if (categoria.Id != 0)
                    {
                        negocio.modificar(categoria);
                        MessageBox.Show("Modificado exitosamente");
                    }
                    else
                    {
                        negocio.agregar(categoria);
                        MessageBox.Show("Agregado exitosamente");
                    }
                    Close();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAgregarCategoria_Load(object sender, EventArgs e)
        {
            if (categoria != null)
            {
                txtDescripcionCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
