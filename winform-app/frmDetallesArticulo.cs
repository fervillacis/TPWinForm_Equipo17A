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
    public partial class frmDetallesArticulo : Form
    {

        private Articulo articulo;
        List<string> imagenes = new List<string>();
        int indiceImagen = 0;

        public frmDetallesArticulo(Articulo articulo)
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.articulo = articulo;

            // Cargar datos directamente acá
            label2.Text = articulo.Codigo;
            label4.Text = articulo.Nombre;
            label6.Text = articulo.Descripcion;

            label8.Text = articulo.Marca != null ? articulo.Marca.Descripcion : "-";
            label10.Text = articulo.Categoria != null ? articulo.Categoria.Descripcion : "-";

            label12.Text = articulo.Precio.ToString();

            ArticuloNegocio negocio = new ArticuloNegocio();
            imagenes = negocio.ObtenerImagenesPorId(articulo.Id);

            if (imagenes.Count > 0)
            {
                mostrarImagen();
            }
            else
            {
                pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void mostrarImagen()
        {
            try
            {
                pictureBox1.Load(imagenes[indiceImagen]);
            }
            catch
            {
                pictureBox1.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                indiceImagen--;

                if (indiceImagen < 0)
                    indiceImagen = imagenes.Count - 1;

                mostrarImagen();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (imagenes.Count > 0)
            {
                indiceImagen++;

                if (indiceImagen >= imagenes.Count)
                    indiceImagen = 0;

                mostrarImagen();
            }
        }
    }


}
