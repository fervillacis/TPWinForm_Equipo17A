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
        }

        private void btnModificarMarcas_Click(object sender, EventArgs e)
        {
            Marca seleccionado;
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo");
                return;
            }
            seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            frmAgregarMarca modificar = new frmAgregarMarca(seleccionado);
            modificar.ShowDialog();
        }

        private void btnEliminarMarcas_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;

            var resp = MessageBox.Show(
                "¿Eliminar la marca seleccionada?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                negocio.eliminar(seleccionado.Id);
            }
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marca = new MarcaNegocio();
                listaMarcas = marca.listarMarcas();

                dgvMarcas.DataSource = null; 
                dgvMarcas.DataSource = listaMarcas; 
                dgvMarcas.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
