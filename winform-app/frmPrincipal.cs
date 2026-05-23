using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace winform_app
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void seleccionarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            abrirVentana(new frmArticulos());
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentana(new frmCategorias());
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirVentana(new frmMarcas());
        }

        private void abrirVentana(Form ventana)
        {
            if(this.ActiveMdiChild != null)
            {
                MessageBox.Show("Ya hay una sección activa en pantalla. Por favor, ciérrela para poder abrir una nueva ventana de trabajo.", "Sección en Uso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                List<Articulo> lista = negocio.listar();

                string resultado = "";

                foreach (Articulo item in lista)
                {
                    resultado += item.Codigo + " - " + item.Nombre + " - "
                              + item.Marca.Descripcion + " - "
                              + item.Categoria.Descripcion + " - $"
                              + item.Precio + "\n";
                }

                MessageBox.Show(resultado);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un problema inesperado al generar el resumen rápido de artículos.", "Error de Generación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
