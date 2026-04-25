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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
        }

        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
        }

        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnDetallesArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAnteriorArticulo_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguienteArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cboCampoArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCampoArticulo_Click(object sender, EventArgs e)
        {

        }

        private void lblCriterioArticulo_Click(object sender, EventArgs e)
        {

        }

        private void cboCriterioArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFiltroArticulo_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltroArticulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnArticuloBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
