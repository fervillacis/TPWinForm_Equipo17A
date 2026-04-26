namespace winform_app
{
    partial class frmAgregarMarca
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
            this.txtDescripcionMarca = new System.Windows.Forms.TextBox();
            this.lblDescripcionMarca = new System.Windows.Forms.Label();
            this.btnCancelarMarca = new System.Windows.Forms.Button();
            this.btnAceptarMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcionMarca
            // 
            this.txtDescripcionMarca.Location = new System.Drawing.Point(162, 71);
            this.txtDescripcionMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionMarca.Name = "txtDescripcionMarca";
            this.txtDescripcionMarca.Size = new System.Drawing.Size(176, 22);
            this.txtDescripcionMarca.TabIndex = 11;
            // 
            // lblDescripcionMarca
            // 
            this.lblDescripcionMarca.AutoSize = true;
            this.lblDescripcionMarca.Location = new System.Drawing.Point(69, 71);
            this.lblDescripcionMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionMarca.Name = "lblDescripcionMarca";
            this.lblDescripcionMarca.Size = new System.Drawing.Size(79, 16);
            this.lblDescripcionMarca.TabIndex = 10;
            this.lblDescripcionMarca.Text = "Descripcion";
            // 
            // btnCancelarMarca
            // 
            this.btnCancelarMarca.Location = new System.Drawing.Point(217, 121);
            this.btnCancelarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarMarca.Name = "btnCancelarMarca";
            this.btnCancelarMarca.Size = new System.Drawing.Size(121, 37);
            this.btnCancelarMarca.TabIndex = 9;
            this.btnCancelarMarca.Text = "Cancelar";
            this.btnCancelarMarca.UseVisualStyleBackColor = true;
            this.btnCancelarMarca.Click += new System.EventHandler(this.btnCancelarMarca_Click);
            // 
            // btnAceptarMarca
            // 
            this.btnAceptarMarca.Location = new System.Drawing.Point(70, 121);
            this.btnAceptarMarca.Margin = new System.Windows.Forms.Padding(4);
            this.btnAceptarMarca.Name = "btnAceptarMarca";
            this.btnAceptarMarca.Size = new System.Drawing.Size(121, 37);
            this.btnAceptarMarca.TabIndex = 8;
            this.btnAceptarMarca.Text = "Aceptar";
            this.btnAceptarMarca.UseVisualStyleBackColor = true;
            this.btnAceptarMarca.Click += new System.EventHandler(this.btnAceptarMarca_Click);
            // 
            // frmAgregarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDescripcionMarca);
            this.Controls.Add(this.lblDescripcionMarca);
            this.Controls.Add(this.btnCancelarMarca);
            this.Controls.Add(this.btnAceptarMarca);
            this.Name = "frmAgregarMarca";
            this.Text = "frmAgregarMarca";
            this.Load += new System.EventHandler(this.frmAgregarMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcionMarca;
        private System.Windows.Forms.Label lblDescripcionMarca;
        private System.Windows.Forms.Button btnCancelarMarca;
        private System.Windows.Forms.Button btnAceptarMarca;
    }
}