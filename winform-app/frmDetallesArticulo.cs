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

namespace winform_app
{
    public partial class frmDetallesArticulo : Form
    {

        private Articulo articulo;

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

            try
            {
                pictureBox1.Load(articulo.ImagenUrl);
            }
            catch
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
    }
}
