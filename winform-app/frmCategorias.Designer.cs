namespace winform_app
{
    partial class frmCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.btnEliminarCategorias = new System.Windows.Forms.Button();
            this.btnModificarCategorias = new System.Windows.Forms.Button();
            this.btnAgregarCategorias = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCategorias.Location = new System.Drawing.Point(46, 26);
            this.dgvCategorias.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCategorias.MultiSelect = false;
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.Size = new System.Drawing.Size(336, 184);
            this.dgvCategorias.TabIndex = 4;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            // 
            // btnEliminarCategorias
            // 
            this.btnEliminarCategorias.Location = new System.Drawing.Point(274, 233);
            this.btnEliminarCategorias.Name = "btnEliminarCategorias";
            this.btnEliminarCategorias.Size = new System.Drawing.Size(108, 41);
            this.btnEliminarCategorias.TabIndex = 10;
            this.btnEliminarCategorias.Text = "Eliminar";
            this.btnEliminarCategorias.UseVisualStyleBackColor = true;
            this.btnEliminarCategorias.Click += new System.EventHandler(this.btnEliminarArticulo_Click);
            // 
            // btnModificarCategorias
            // 
            this.btnModificarCategorias.Location = new System.Drawing.Point(160, 233);
            this.btnModificarCategorias.Name = "btnModificarCategorias";
            this.btnModificarCategorias.Size = new System.Drawing.Size(108, 41);
            this.btnModificarCategorias.TabIndex = 9;
            this.btnModificarCategorias.Text = "Modificar";
            this.btnModificarCategorias.UseVisualStyleBackColor = true;
            this.btnModificarCategorias.Click += new System.EventHandler(this.btnModificarArticulo_Click);
            // 
            // btnAgregarCategorias
            // 
            this.btnAgregarCategorias.Location = new System.Drawing.Point(46, 233);
            this.btnAgregarCategorias.Name = "btnAgregarCategorias";
            this.btnAgregarCategorias.Size = new System.Drawing.Size(108, 41);
            this.btnAgregarCategorias.TabIndex = 8;
            this.btnAgregarCategorias.Text = "Agregar";
            this.btnAgregarCategorias.UseVisualStyleBackColor = true;
            this.btnAgregarCategorias.Click += new System.EventHandler(this.btnAgregarArticulo_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminarCategorias);
            this.Controls.Add(this.btnModificarCategorias);
            this.Controls.Add(this.btnAgregarCategorias);
            this.Controls.Add(this.dgvCategorias);
            this.Name = "frmCategorias";
            this.Text = "frmCategorias";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button btnEliminarCategorias;
        private System.Windows.Forms.Button btnModificarCategorias;
        private System.Windows.Forms.Button btnAgregarCategorias;
    }
}