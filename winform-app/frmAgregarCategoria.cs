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


        private void btnAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            try
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.Descripcion = txtDescripcionCategoria.Text;

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
