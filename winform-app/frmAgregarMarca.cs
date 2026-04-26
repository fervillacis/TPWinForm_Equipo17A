using Negocio;
using Dominio;
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
    public partial class frmAgregarMarca : Form
    {
        Marca marca = null;

        public frmAgregarMarca()
        {
            InitializeComponent();
        }
        public frmAgregarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar marca";
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnAceptarMarca_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                if (marca == null)
                {
                    marca = new Marca();
                }
                marca.Descripcion = txtDescripcionMarca.Text;

                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Agregado exitosamente");
                }
            Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmAgregarMarca_Load(object sender, EventArgs e)
        {


            if (marca != null)
            {
                txtDescripcionMarca.Text = marca.Descripcion;
            }

        }
    }
}
