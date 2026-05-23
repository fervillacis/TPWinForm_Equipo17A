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
    public partial class frmMarcas : Form
    {
        private List<Marca> listaMarcas;
        public frmMarcas()
        {
            InitializeComponent();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void btnAgregarMarcas_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregarMarca = new frmAgregarMarca();
            agregarMarca.ShowDialog();
            cargarMarcas();

        }

        private void btnModificarMarcas_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, elija una marca de la lista para poder llevar a cabo la operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarca modificar = new frmAgregarMarca(seleccionado);
            modificar.ShowDialog();
            cargarMarcas();

        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Por favor, elija una marca de la lista para poder llevar a cabo la operación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            if (negocio.validarEliminarMarca(seleccionado.Id))
            {
                MessageBox.Show(
                    "No se puede eliminar la marca porque está asociada a uno o más artículos.",
                    "Eliminación no permitida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            var resp = MessageBox.Show(
                "¿Eliminar la marca seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                negocio.eliminar(seleccionado.Id);
                MessageBox.Show("La marca seleccionada se ha eliminado exitosamente.", "Marca Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargarMarcas();

        }
        private void cargarMarcas()
        {
            try
            {
                MarcaNegocio marca = new MarcaNegocio();
                listaMarcas = marca.listarMarcas();

                dgvMarcas.DataSource = null;
                dgvMarcas.DataSource = listaMarcas;
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar la lista de marcas. Si el problema persiste, contacte al servicio técnico.", "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }
    }
}
