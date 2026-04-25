namespace winform_app
{
    partial class frmArticulos
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
            this.lblFiltroArticuloTop = new System.Windows.Forms.Label();
            this.txtFiltroArticuloTop = new System.Windows.Forms.TextBox();
            this.btnAgregarArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnModificarArticulo = new System.Windows.Forms.Button();
            this.btnEliminarArticulo = new System.Windows.Forms.Button();
            this.btnDetallesArticulos = new System.Windows.Forms.Button();
            this.lblCampoArticulo = new System.Windows.Forms.Label();
            this.lblCriterioArticulo = new System.Windows.Forms.Label();
            this.lblFiltroArticulo = new System.Windows.Forms.Label();
            this.cboCampoArticulo = new System.Windows.Forms.ComboBox();
            this.cboCriterioArticulo = new System.Windows.Forms.ComboBox();
            this.txtFiltroArticulo = new System.Windows.Forms.TextBox();
            this.btnArticuloBuscar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiarArticulo = new System.Windows.Forms.Button();
            this.btnAnteriorArticulo = new System.Windows.Forms.Button();
            this.btnSiguienteArticulo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltroArticuloTop
            // 
            this.lblFiltroArticuloTop.AutoSize = true;
            this.lblFiltroArticuloTop.Location = new System.Drawing.Point(12, 26);
            this.lblFiltroArticuloTop.Name = "lblFiltroArticuloTop";
            this.lblFiltroArticuloTop.Size = new System.Drawing.Size(36, 16);
            this.lblFiltroArticuloTop.TabIndex = 0;
            this.lblFiltroArticuloTop.Text = "Filtro";
            this.lblFiltroArticuloTop.Click += new System.EventHandler(this.lblFiltro_Click);
            // 
            // txtFiltroArticuloTop
            // 
            this.txtFiltroArticuloTop.Location = new System.Drawing.Point(80, 23);
            this.txtFiltroArticuloTop.Name = "txtFiltroArticuloTop";
            this.txtFiltroArticuloTop.Size = new System.Drawing.Size(175, 22);
            this.txtFiltroArticuloTop.TabIndex = 1;
            this.txtFiltroArticuloTop.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnAgregarArticulo
            // 
            this.btnAgregarArticulo.Location = new System.Drawing.Point(42, 313);
            this.btnAgregarArticulo.Name = "btnAgregarArticulo";
            this.btnAgregarArticulo.Size = new System.Drawing.Size(108, 41);
            this.btnAgregarArticulo.TabIndex = 2;
            this.btnAgregarArticulo.Text = "Agregar";
            this.btnAgregarArticulo.UseVisualStyleBackColor = true;
            this.btnAgregarArticulo.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(31, 51);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.RowTemplate.Height = 24;
            this.dgvArticulos.Size = new System.Drawing.Size(738, 239);
            this.dgvArticulos.TabIndex = 3;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModificarArticulo
            // 
            this.btnModificarArticulo.Location = new System.Drawing.Point(156, 313);
            this.btnModificarArticulo.Name = "btnModificarArticulo";
            this.btnModificarArticulo.Size = new System.Drawing.Size(108, 41);
            this.btnModificarArticulo.TabIndex = 4;
            this.btnModificarArticulo.Text = "Modificar";
            this.btnModificarArticulo.UseVisualStyleBackColor = true;
            this.btnModificarArticulo.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnEliminarArticulo
            // 
            this.btnEliminarArticulo.Location = new System.Drawing.Point(270, 313);
            this.btnEliminarArticulo.Name = "btnEliminarArticulo";
            this.btnEliminarArticulo.Size = new System.Drawing.Size(108, 41);
            this.btnEliminarArticulo.TabIndex = 5;
            this.btnEliminarArticulo.Text = "Eliminar";
            this.btnEliminarArticulo.UseVisualStyleBackColor = true;
            this.btnEliminarArticulo.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnDetallesArticulos
            // 
            this.btnDetallesArticulos.Location = new System.Drawing.Point(384, 313);
            this.btnDetallesArticulos.Name = "btnDetallesArticulos";
            this.btnDetallesArticulos.Size = new System.Drawing.Size(108, 41);
            this.btnDetallesArticulos.TabIndex = 6;
            this.btnDetallesArticulos.Text = "Ver detalles";
            this.btnDetallesArticulos.UseVisualStyleBackColor = true;
            this.btnDetallesArticulos.Click += new System.EventHandler(this.btnDetallesArticulos_Click);
            // 
            // lblCampoArticulo
            // 
            this.lblCampoArticulo.AutoSize = true;
            this.lblCampoArticulo.Location = new System.Drawing.Point(28, 392);
            this.lblCampoArticulo.Name = "lblCampoArticulo";
            this.lblCampoArticulo.Size = new System.Drawing.Size(51, 16);
            this.lblCampoArticulo.TabIndex = 7;
            this.lblCampoArticulo.Text = "Campo";
            this.lblCampoArticulo.Click += new System.EventHandler(this.lblCampoArticulo_Click);
            // 
            // lblCriterioArticulo
            // 
            this.lblCriterioArticulo.AutoSize = true;
            this.lblCriterioArticulo.Location = new System.Drawing.Point(233, 389);
            this.lblCriterioArticulo.Name = "lblCriterioArticulo";
            this.lblCriterioArticulo.Size = new System.Drawing.Size(49, 16);
            this.lblCriterioArticulo.TabIndex = 8;
            this.lblCriterioArticulo.Text = "Criterio";
            this.lblCriterioArticulo.Click += new System.EventHandler(this.lblCriterioArticulo_Click);
            // 
            // lblFiltroArticulo
            // 
            this.lblFiltroArticulo.AutoSize = true;
            this.lblFiltroArticulo.Location = new System.Drawing.Point(438, 389);
            this.lblFiltroArticulo.Name = "lblFiltroArticulo";
            this.lblFiltroArticulo.Size = new System.Drawing.Size(36, 16);
            this.lblFiltroArticulo.TabIndex = 10;
            this.lblFiltroArticulo.Text = "Filtro";
            this.lblFiltroArticulo.Click += new System.EventHandler(this.lblFiltroArticulo_Click);
            // 
            // cboCampoArticulo
            // 
            this.cboCampoArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampoArticulo.FormattingEnabled = true;
            this.cboCampoArticulo.Location = new System.Drawing.Point(86, 387);
            this.cboCampoArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCampoArticulo.Name = "cboCampoArticulo";
            this.cboCampoArticulo.Size = new System.Drawing.Size(132, 24);
            this.cboCampoArticulo.TabIndex = 16;
            this.cboCampoArticulo.SelectedIndexChanged += new System.EventHandler(this.cboCampoArticulo_SelectedIndexChanged);
            // 
            // cboCriterioArticulo
            // 
            this.cboCriterioArticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterioArticulo.FormattingEnabled = true;
            this.cboCriterioArticulo.Location = new System.Drawing.Point(289, 384);
            this.cboCriterioArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCriterioArticulo.Name = "cboCriterioArticulo";
            this.cboCriterioArticulo.Size = new System.Drawing.Size(132, 24);
            this.cboCriterioArticulo.TabIndex = 17;
            this.cboCriterioArticulo.SelectedIndexChanged += new System.EventHandler(this.cboCriterioArticulo_SelectedIndexChanged);
            // 
            // txtFiltroArticulo
            // 
            this.txtFiltroArticulo.Location = new System.Drawing.Point(480, 383);
            this.txtFiltroArticulo.Name = "txtFiltroArticulo";
            this.txtFiltroArticulo.Size = new System.Drawing.Size(175, 22);
            this.txtFiltroArticulo.TabIndex = 18;
            this.txtFiltroArticulo.TextChanged += new System.EventHandler(this.txtFiltroArticulo_TextChanged);
            // 
            // btnArticuloBuscar
            // 
            this.btnArticuloBuscar.Location = new System.Drawing.Point(661, 370);
            this.btnArticuloBuscar.Name = "btnArticuloBuscar";
            this.btnArticuloBuscar.Size = new System.Drawing.Size(108, 41);
            this.btnArticuloBuscar.TabIndex = 19;
            this.btnArticuloBuscar.Text = "Buscar";
            this.btnArticuloBuscar.UseVisualStyleBackColor = true;
            this.btnArticuloBuscar.Click += new System.EventHandler(this.btnArticuloBuscar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(775, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 239);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpiarArticulo
            // 
            this.btnLimpiarArticulo.Location = new System.Drawing.Point(775, 296);
            this.btnLimpiarArticulo.Name = "btnLimpiarArticulo";
            this.btnLimpiarArticulo.Size = new System.Drawing.Size(105, 41);
            this.btnLimpiarArticulo.TabIndex = 21;
            this.btnLimpiarArticulo.Text = "Limpiar";
            this.btnLimpiarArticulo.UseVisualStyleBackColor = true;
            this.btnLimpiarArticulo.Click += new System.EventHandler(this.btnLimpiarArticulo_Click);
            // 
            // btnAnteriorArticulo
            // 
            this.btnAnteriorArticulo.Location = new System.Drawing.Point(889, 296);
            this.btnAnteriorArticulo.Name = "btnAnteriorArticulo";
            this.btnAnteriorArticulo.Size = new System.Drawing.Size(105, 41);
            this.btnAnteriorArticulo.TabIndex = 22;
            this.btnAnteriorArticulo.Text = "Anterior";
            this.btnAnteriorArticulo.UseVisualStyleBackColor = true;
            this.btnAnteriorArticulo.Click += new System.EventHandler(this.btnAnteriorArticulo_Click);
            // 
            // btnSiguienteArticulo
            // 
            this.btnSiguienteArticulo.Location = new System.Drawing.Point(1003, 296);
            this.btnSiguienteArticulo.Name = "btnSiguienteArticulo";
            this.btnSiguienteArticulo.Size = new System.Drawing.Size(105, 41);
            this.btnSiguienteArticulo.TabIndex = 23;
            this.btnSiguienteArticulo.Text = "Siguiente";
            this.btnSiguienteArticulo.UseVisualStyleBackColor = true;
            this.btnSiguienteArticulo.Click += new System.EventHandler(this.btnSiguienteArticulo_Click);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 433);
            this.Controls.Add(this.btnSiguienteArticulo);
            this.Controls.Add(this.btnAnteriorArticulo);
            this.Controls.Add(this.btnLimpiarArticulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnArticuloBuscar);
            this.Controls.Add(this.txtFiltroArticulo);
            this.Controls.Add(this.cboCriterioArticulo);
            this.Controls.Add(this.cboCampoArticulo);
            this.Controls.Add(this.lblFiltroArticulo);
            this.Controls.Add(this.lblCriterioArticulo);
            this.Controls.Add(this.lblCampoArticulo);
            this.Controls.Add(this.btnDetallesArticulos);
            this.Controls.Add(this.btnEliminarArticulo);
            this.Controls.Add(this.btnModificarArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregarArticulo);
            this.Controls.Add(this.txtFiltroArticuloTop);
            this.Controls.Add(this.lblFiltroArticuloTop);
            this.Name = "frmArticulos";
            this.Text = "frmArticulos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltroArticuloTop;
        private System.Windows.Forms.TextBox txtFiltroArticuloTop;
        private System.Windows.Forms.Button btnAgregarArticulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnModificarArticulo;
        private System.Windows.Forms.Button btnEliminarArticulo;
        private System.Windows.Forms.Button btnDetallesArticulos;
        private System.Windows.Forms.Label lblCampoArticulo;
        private System.Windows.Forms.Label lblCriterioArticulo;
        private System.Windows.Forms.Label lblFiltroArticulo;
        private System.Windows.Forms.ComboBox cboCampoArticulo;
        private System.Windows.Forms.ComboBox cboCriterioArticulo;
        private System.Windows.Forms.TextBox txtFiltroArticulo;
        private System.Windows.Forms.Button btnArticuloBuscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiarArticulo;
        private System.Windows.Forms.Button btnAnteriorArticulo;
        private System.Windows.Forms.Button btnSiguienteArticulo;
    }
}