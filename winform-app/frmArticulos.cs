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
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulos;
        private List<Imagen> listaImagenes;
        private int indiceImagenActual = 0;


        public frmArticulos()
        {
            InitializeComponent();
            this.Load += frmArticulos_Load; // cuando el formulario se abre se ejecuta el metodo
        }

        //   CARGAR
        private void cargar() // carga y muestra los datos en el DataGridView
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulos = negocio.listar();

                dgvArticulos.DataSource = null; // limpia para que no quede info vieja
                dgvArticulos.DataSource = listaArticulos; // muestra lo que hay en el objeto listaArticulos
                dgvArticulos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroArticuloTop.Text.ToUpper();

            if (filtro.Length >= 2)
            {
                List<Articulo> listaFiltrada = listaArticulos.FindAll(x =>
                    x.Codigo.ToUpper().Contains(filtro) ||
                    x.Nombre.ToUpper().Contains(filtro) ||
                    x.Descripcion.ToUpper().Contains(filtro) ||
                    x.Marca.Descripcion.ToUpper().Contains(filtro) ||
                    x.Categoria.Descripcion.ToUpper().Contains(filtro)
                );

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaFiltrada;
            }
            else
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = listaArticulos;
            }

       
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //    Agregar Articulo
        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            frmAgregarArticulo agregarArticulo = new frmAgregarArticulo();
            agregarArticulo.ShowDialog();
            cargar(); // recarga para ver lo que se agrego
        }

        //     Modificar Articulo 
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            if (dgvArticulos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un articulo");
                return;
            }
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregarArticulo modificar = new frmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
        }
           
        
        //   Eliminar Articulo   
        private void btnEliminarArticulo_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            var resp = MessageBox.Show(
                "¿Eliminar el artículo seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resp == DialogResult.Yes)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.eliminar(seleccionado.Id);
                cargar();
            }
        }

        private void btnDetallesArticulos_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiarArticulo_Click(object sender, EventArgs e)
        {

        }

        private void mostrarImagenActual()
        {
            if (listaImagenes != null && listaImagenes.Count > 0)
            {
                try
                {
                    pictureBox1.Load(listaImagenes[indiceImagenActual].ImagenUrl);
                }

                catch (Exception ex)
                {
                    pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
                }
            }
            else
            {
                pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }


        private void btnAnteriorArticulo_Click(object sender, EventArgs e)
        {
            if (listaImagenes != null && indiceImagenActual > 0)
            {
                indiceImagenActual--;
                mostrarImagenActual();
            }
            else if (listaImagenes != null && indiceImagenActual == 0)
            {
                indiceImagenActual = listaImagenes.Count - 1;
                mostrarImagenActual();
            }

        }

        private void btnSiguienteArticulo_Click(object sender, EventArgs e)
        {
            if (listaImagenes != null && indiceImagenActual < listaImagenes.Count - 1)
            {
                indiceImagenActual++;
                mostrarImagenActual();
            }
            else if (listaImagenes != null && indiceImagenActual == listaImagenes.Count - 1)
            {
                indiceImagenActual = 0;
                mostrarImagenActual();
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
