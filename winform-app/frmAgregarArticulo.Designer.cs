namespace winform_app
{
    partial class frmAgregarArticulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarImagenAgregarArticulo = new System.Windows.Forms.Button();
            this.btnQuitarImagenAgregarArticulo = new System.Windows.Forms.Button();
            this.pbxArticuloAgregarArticulo = new System.Windows.Forms.PictureBox();
            this.lblMarcasAgregarArticulo = new System.Windows.Forms.Label();
            this.lblCategoriaAgregarArticulo = new System.Windows.Forms.Label();
            this.lblUrlImagenAgregarArticulo = new System.Windows.Forms.Label();
            this.lblPrecioAgregarArticulo = new System.Windows.Forms.Label();
            this.lblDescripcionAgregarArticulo = new System.Windows.Forms.Label();
            this.lblNombreAgregarArticulo = new System.Windows.Forms.Label();
            this.lblCodigoAgregarArticulo = new System.Windows.Forms.Label();
            this.cboMarcasAgregarArticulo = new System.Windows.Forms.ComboBox();
            this.cboCategoriasAgregarArticulo = new System.Windows.Forms.ComboBox();
            this.txtUrlImagenAgregarArticulo = new System.Windows.Forms.TextBox();
            this.txtPrecioAgregarArticulo = new System.Windows.Forms.TextBox();
            this.txtDescripcionAgregarArticulo = new System.Windows.Forms.TextBox();
            this.txtNombreAgregarArticulo = new System.Windows.Forms.TextBox();
            this.txtCodigoAgregarArticulo = new System.Windows.Forms.TextBox();
            this.btnCancelarArticuloAgregarArticulo = new System.Windows.Forms.Button();
            this.btnAceptarArticuloAgregarArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAgregarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarImagenAgregarArticulo
            // 
            this.btnAgregarImagenAgregarArticulo.Location = new System.Drawing.Point(457, 344);
            this.btnAgregarImagenAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarImagenAgregarArticulo.Name = "btnAgregarImagenAgregarArticulo";
            this.btnAgregarImagenAgregarArticulo.Size = new System.Drawing.Size(160, 31);
            this.btnAgregarImagenAgregarArticulo.TabIndex = 37;
            this.btnAgregarImagenAgregarArticulo.Text = "Agregar imagen";
            this.btnAgregarImagenAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarImagenAgregarArticulo.Click += new System.EventHandler(this.btnAgregarImagenAgregarArticulo_Click);
            // 
            // btnQuitarImagenAgregarArticulo
            // 
            this.btnQuitarImagenAgregarArticulo.Location = new System.Drawing.Point(665, 344);
            this.btnQuitarImagenAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarImagenAgregarArticulo.Name = "btnQuitarImagenAgregarArticulo";
            this.btnQuitarImagenAgregarArticulo.Size = new System.Drawing.Size(160, 31);
            this.btnQuitarImagenAgregarArticulo.TabIndex = 36;
            this.btnQuitarImagenAgregarArticulo.Text = "Quitar imagen";
            this.btnQuitarImagenAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnQuitarImagenAgregarArticulo.Click += new System.EventHandler(this.btnQuitarImagenAgregarArticulo_Click);
            // 
            // pbxArticuloAgregarArticulo
            // 
            this.pbxArticuloAgregarArticulo.Location = new System.Drawing.Point(424, 47);
            this.pbxArticuloAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.pbxArticuloAgregarArticulo.Name = "pbxArticuloAgregarArticulo";
            this.pbxArticuloAgregarArticulo.Size = new System.Drawing.Size(431, 271);
            this.pbxArticuloAgregarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticuloAgregarArticulo.TabIndex = 35;
            this.pbxArticuloAgregarArticulo.TabStop = false;
            this.pbxArticuloAgregarArticulo.Click += new System.EventHandler(this.pbxArticuloAgregarArticulo_Click);
            // 
            // lblMarcasAgregarArticulo
            // 
            this.lblMarcasAgregarArticulo.AutoSize = true;
            this.lblMarcasAgregarArticulo.Location = new System.Drawing.Point(51, 298);
            this.lblMarcasAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarcasAgregarArticulo.Name = "lblMarcasAgregarArticulo";
            this.lblMarcasAgregarArticulo.Size = new System.Drawing.Size(45, 16);
            this.lblMarcasAgregarArticulo.TabIndex = 34;
            this.lblMarcasAgregarArticulo.Text = "Marca";
            // 
            // lblCategoriaAgregarArticulo
            // 
            this.lblCategoriaAgregarArticulo.AutoSize = true;
            this.lblCategoriaAgregarArticulo.Location = new System.Drawing.Point(51, 256);
            this.lblCategoriaAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoriaAgregarArticulo.Name = "lblCategoriaAgregarArticulo";
            this.lblCategoriaAgregarArticulo.Size = new System.Drawing.Size(66, 16);
            this.lblCategoriaAgregarArticulo.TabIndex = 33;
            this.lblCategoriaAgregarArticulo.Text = "Categoría";
            // 
            // lblUrlImagenAgregarArticulo
            // 
            this.lblUrlImagenAgregarArticulo.AutoSize = true;
            this.lblUrlImagenAgregarArticulo.Location = new System.Drawing.Point(48, 215);
            this.lblUrlImagenAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUrlImagenAgregarArticulo.Name = "lblUrlImagenAgregarArticulo";
            this.lblUrlImagenAgregarArticulo.Size = new System.Drawing.Size(72, 16);
            this.lblUrlImagenAgregarArticulo.TabIndex = 32;
            this.lblUrlImagenAgregarArticulo.Text = "Url Imagen";
            // 
            // lblPrecioAgregarArticulo
            // 
            this.lblPrecioAgregarArticulo.AutoSize = true;
            this.lblPrecioAgregarArticulo.Location = new System.Drawing.Point(51, 174);
            this.lblPrecioAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioAgregarArticulo.Name = "lblPrecioAgregarArticulo";
            this.lblPrecioAgregarArticulo.Size = new System.Drawing.Size(46, 16);
            this.lblPrecioAgregarArticulo.TabIndex = 31;
            this.lblPrecioAgregarArticulo.Text = "Precio";
            // 
            // lblDescripcionAgregarArticulo
            // 
            this.lblDescripcionAgregarArticulo.AutoSize = true;
            this.lblDescripcionAgregarArticulo.Location = new System.Drawing.Point(49, 133);
            this.lblDescripcionAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionAgregarArticulo.Name = "lblDescripcionAgregarArticulo";
            this.lblDescripcionAgregarArticulo.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionAgregarArticulo.TabIndex = 30;
            this.lblDescripcionAgregarArticulo.Text = "Descripción";
            // 
            // lblNombreAgregarArticulo
            // 
            this.lblNombreAgregarArticulo.AutoSize = true;
            this.lblNombreAgregarArticulo.Location = new System.Drawing.Point(51, 93);
            this.lblNombreAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreAgregarArticulo.Name = "lblNombreAgregarArticulo";
            this.lblNombreAgregarArticulo.Size = new System.Drawing.Size(56, 16);
            this.lblNombreAgregarArticulo.TabIndex = 29;
            this.lblNombreAgregarArticulo.Text = "Nombre";
            // 
            // lblCodigoAgregarArticulo
            // 
            this.lblCodigoAgregarArticulo.AutoSize = true;
            this.lblCodigoAgregarArticulo.Location = new System.Drawing.Point(52, 52);
            this.lblCodigoAgregarArticulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigoAgregarArticulo.Name = "lblCodigoAgregarArticulo";
            this.lblCodigoAgregarArticulo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigoAgregarArticulo.TabIndex = 28;
            this.lblCodigoAgregarArticulo.Text = "Código";
            // 
            // cboMarcasAgregarArticulo
            // 
            this.cboMarcasAgregarArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarcasAgregarArticulo.FormattingEnabled = true;
            this.cboMarcasAgregarArticulo.Location = new System.Drawing.Point(145, 293);
            this.cboMarcasAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboMarcasAgregarArticulo.Name = "cboMarcasAgregarArticulo";
            this.cboMarcasAgregarArticulo.Size = new System.Drawing.Size(160, 24);
            this.cboMarcasAgregarArticulo.TabIndex = 27;
            // 
            // cboCategoriasAgregarArticulo
            // 
            this.cboCategoriasAgregarArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriasAgregarArticulo.FormattingEnabled = true;
            this.cboCategoriasAgregarArticulo.Location = new System.Drawing.Point(145, 251);
            this.cboCategoriasAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoriasAgregarArticulo.Name = "cboCategoriasAgregarArticulo";
            this.cboCategoriasAgregarArticulo.Size = new System.Drawing.Size(160, 24);
            this.cboCategoriasAgregarArticulo.TabIndex = 26;
            // 
            // txtUrlImagenAgregarArticulo
            // 
            this.txtUrlImagenAgregarArticulo.Location = new System.Drawing.Point(145, 211);
            this.txtUrlImagenAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrlImagenAgregarArticulo.Name = "txtUrlImagenAgregarArticulo";
            this.txtUrlImagenAgregarArticulo.Size = new System.Drawing.Size(160, 22);
            this.txtUrlImagenAgregarArticulo.TabIndex = 25;
            // 
            // txtPrecioAgregarArticulo
            // 
            this.txtPrecioAgregarArticulo.Location = new System.Drawing.Point(145, 170);
            this.txtPrecioAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioAgregarArticulo.Name = "txtPrecioAgregarArticulo";
            this.txtPrecioAgregarArticulo.Size = new System.Drawing.Size(160, 22);
            this.txtPrecioAgregarArticulo.TabIndex = 24;
            // 
            // txtDescripcionAgregarArticulo
            // 
            this.txtDescripcionAgregarArticulo.Location = new System.Drawing.Point(145, 130);
            this.txtDescripcionAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionAgregarArticulo.Name = "txtDescripcionAgregarArticulo";
            this.txtDescripcionAgregarArticulo.Size = new System.Drawing.Size(160, 22);
            this.txtDescripcionAgregarArticulo.TabIndex = 23;
            // 
            // txtNombreAgregarArticulo
            // 
            this.txtNombreAgregarArticulo.Location = new System.Drawing.Point(145, 89);
            this.txtNombreAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreAgregarArticulo.Name = "txtNombreAgregarArticulo";
            this.txtNombreAgregarArticulo.Size = new System.Drawing.Size(160, 22);
            this.txtNombreAgregarArticulo.TabIndex = 22;
            // 
            // txtCodigoAgregarArticulo
            // 
            this.txtCodigoAgregarArticulo.Location = new System.Drawing.Point(145, 48);
            this.txtCodigoAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoAgregarArticulo.Name = "txtCodigoAgregarArticulo";
            this.txtCodigoAgregarArticulo.Size = new System.Drawing.Size(160, 22);
            this.txtCodigoAgregarArticulo.TabIndex = 21;
            // 
            // btnCancelarArticuloAgregarArticulo
            // 
            this.btnCancelarArticuloAgregarArticulo.Location = new System.Drawing.Point(201, 366);
            this.btnCancelarArticuloAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarArticuloAgregarArticulo.Name = "btnCancelarArticuloAgregarArticulo";
            this.btnCancelarArticuloAgregarArticulo.Size = new System.Drawing.Size(105, 42);
            this.btnCancelarArticuloAgregarArticulo.TabIndex = 20;
            this.btnCancelarArticuloAgregarArticulo.Text = "Cancelar";
            this.btnCancelarArticuloAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnCancelarArticuloAgregarArticulo.Click += new System.EventHandler(this.btnCancelarArticuloAgregarArticulo_Click);
            // 
            // btnAceptarArticuloAgregarArticulo
            // 
            this.btnAceptarArticuloAgregarArticulo.Location = new System.Drawing.Point(49, 366);
            this.btnAceptarArticuloAgregarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarArticuloAgregarArticulo.Name = "btnAceptarArticuloAgregarArticulo";
            this.btnAceptarArticuloAgregarArticulo.Size = new System.Drawing.Size(105, 42);
            this.btnAceptarArticuloAgregarArticulo.TabIndex = 19;
            this.btnAceptarArticuloAgregarArticulo.Text = "Aceptar";
            this.btnAceptarArticuloAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAceptarArticuloAgregarArticulo.Click += new System.EventHandler(this.btnAceptarArticuloAgregarArticulo_Click);
            // 
            // frmAgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 540);
            this.Controls.Add(this.btnAgregarImagenAgregarArticulo);
            this.Controls.Add(this.btnQuitarImagenAgregarArticulo);
            this.Controls.Add(this.pbxArticuloAgregarArticulo);
            this.Controls.Add(this.lblMarcasAgregarArticulo);
            this.Controls.Add(this.lblCategoriaAgregarArticulo);
            this.Controls.Add(this.lblUrlImagenAgregarArticulo);
            this.Controls.Add(this.lblPrecioAgregarArticulo);
            this.Controls.Add(this.lblDescripcionAgregarArticulo);
            this.Controls.Add(this.lblNombreAgregarArticulo);
            this.Controls.Add(this.lblCodigoAgregarArticulo);
            this.Controls.Add(this.cboMarcasAgregarArticulo);
            this.Controls.Add(this.cboCategoriasAgregarArticulo);
            this.Controls.Add(this.txtUrlImagenAgregarArticulo);
            this.Controls.Add(this.txtPrecioAgregarArticulo);
            this.Controls.Add(this.txtDescripcionAgregarArticulo);
            this.Controls.Add(this.txtNombreAgregarArticulo);
            this.Controls.Add(this.txtCodigoAgregarArticulo);
            this.Controls.Add(this.btnCancelarArticuloAgregarArticulo);
            this.Controls.Add(this.btnAceptarArticuloAgregarArticulo);
            this.Name = "frmAgregarArticulo";
            this.Text = "AgregarArticulo";
            this.Load += new System.EventHandler(this.frmAgregarArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticuloAgregarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarImagenAgregarArticulo;
        private System.Windows.Forms.Button btnQuitarImagenAgregarArticulo;
        private System.Windows.Forms.PictureBox pbxArticuloAgregarArticulo;
        private System.Windows.Forms.Label lblMarcasAgregarArticulo;
        private System.Windows.Forms.Label lblCategoriaAgregarArticulo;
        private System.Windows.Forms.Label lblUrlImagenAgregarArticulo;
        private System.Windows.Forms.Label lblPrecioAgregarArticulo;
        private System.Windows.Forms.Label lblDescripcionAgregarArticulo;
        private System.Windows.Forms.Label lblNombreAgregarArticulo;
        private System.Windows.Forms.Label lblCodigoAgregarArticulo;
        private System.Windows.Forms.ComboBox cboMarcasAgregarArticulo;
        private System.Windows.Forms.ComboBox cboCategoriasAgregarArticulo;
        private System.Windows.Forms.TextBox txtUrlImagenAgregarArticulo;
        private System.Windows.Forms.TextBox txtPrecioAgregarArticulo;
        private System.Windows.Forms.TextBox txtDescripcionAgregarArticulo;
        private System.Windows.Forms.TextBox txtNombreAgregarArticulo;
        private System.Windows.Forms.TextBox txtCodigoAgregarArticulo;
        private System.Windows.Forms.Button btnCancelarArticuloAgregarArticulo;
        private System.Windows.Forms.Button btnAceptarArticuloAgregarArticulo;
    }
}