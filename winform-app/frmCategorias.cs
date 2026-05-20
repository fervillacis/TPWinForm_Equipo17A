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
    public partial class frmCategorias : Form
    {
        private List<Categoria> listaCategorias;

        public frmCategorias()
        {
            InitializeComponent();
        }



        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Categoria seleccionado;
            if (dgvCategorias.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo");
                return;
            }
            seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            frmAgregarCategoria modificar = new frmAgregarCategoria(seleccionado);
            modificar.ShowDialog();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregarCategoria = new frmAgregarCategoria();
            agregarCategoria.ShowDialog();
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;
            CategoriaNegocio negocio = new CategoriaNegocio();

            if (negocio.validarEliminarCategoria(seleccionado.Id))
            {
                MessageBox.Show(
                "No se puede eliminar la categoria porque está asociada a uno o más artículos.",
                "Eliminación no permitida",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );

                return;
            }
            var resp = MessageBox.Show(
                "¿Eliminar la aategoria seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                negocio.eliminar(seleccionado.Id);
                MessageBox.Show("Categoria eliminada correctamente.");
            }
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            try
            {
                CategoriaNegocio marca = new CategoriaNegocio();
                listaCategorias = marca.listarCategorias();

                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = listaCategorias;
                dgvCategorias.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
