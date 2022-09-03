namespace Desafio_Final
{
    partial class frmDetalle
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
            this.pbxImagen = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.txtDescripcionDetalle = new System.Windows.Forms.TextBox();
            this.txtNombreDetalle = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.lblCategoriaDetalle = new System.Windows.Forms.Label();
            this.lblMarcaDetalle = new System.Windows.Forms.Label();
            this.lblDescripcionDetalle = new System.Windows.Forms.Label();
            this.lblNombreDetalle = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtMarcaDetalle = new System.Windows.Forms.TextBox();
            this.txtCategoriaDetalle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImagen
            // 
            this.pbxImagen.Location = new System.Drawing.Point(358, 12);
            this.pbxImagen.Name = "pbxImagen";
            this.pbxImagen.Size = new System.Drawing.Size(304, 409);
            this.pbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImagen.TabIndex = 3;
            this.pbxImagen.TabStop = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAceptar.Location = new System.Drawing.Point(141, 336);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(97, 38);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDetalle.Location = new System.Drawing.Point(141, 249);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.ReadOnly = true;
            this.txtPrecioDetalle.Size = new System.Drawing.Size(179, 22);
            this.txtPrecioDetalle.TabIndex = 4;
            // 
            // txtDescripcionDetalle
            // 
            this.txtDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionDetalle.Location = new System.Drawing.Point(141, 85);
            this.txtDescripcionDetalle.Name = "txtDescripcionDetalle";
            this.txtDescripcionDetalle.ReadOnly = true;
            this.txtDescripcionDetalle.Size = new System.Drawing.Size(179, 22);
            this.txtDescripcionDetalle.TabIndex = 1;
            // 
            // txtNombreDetalle
            // 
            this.txtNombreDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreDetalle.Location = new System.Drawing.Point(141, 32);
            this.txtNombreDetalle.Name = "txtNombreDetalle";
            this.txtNombreDetalle.ReadOnly = true;
            this.txtNombreDetalle.Size = new System.Drawing.Size(179, 22);
            this.txtNombreDetalle.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, -29);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(179, 22);
            this.txtCodigo.TabIndex = 17;
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDetalle.Location = new System.Drawing.Point(29, 255);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(56, 16);
            this.lblPrecioDetalle.TabIndex = 29;
            this.lblPrecioDetalle.Text = "Precio:";
            // 
            // lblCategoriaDetalle
            // 
            this.lblCategoriaDetalle.AutoSize = true;
            this.lblCategoriaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaDetalle.Location = new System.Drawing.Point(29, 197);
            this.lblCategoriaDetalle.Name = "lblCategoriaDetalle";
            this.lblCategoriaDetalle.Size = new System.Drawing.Size(79, 16);
            this.lblCategoriaDetalle.TabIndex = 24;
            this.lblCategoriaDetalle.Text = "Categoria:";
            // 
            // lblMarcaDetalle
            // 
            this.lblMarcaDetalle.AutoSize = true;
            this.lblMarcaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaDetalle.Location = new System.Drawing.Point(29, 144);
            this.lblMarcaDetalle.Name = "lblMarcaDetalle";
            this.lblMarcaDetalle.Size = new System.Drawing.Size(54, 16);
            this.lblMarcaDetalle.TabIndex = 23;
            this.lblMarcaDetalle.Text = "Marca:";
            // 
            // lblDescripcionDetalle
            // 
            this.lblDescripcionDetalle.AutoSize = true;
            this.lblDescripcionDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionDetalle.Location = new System.Drawing.Point(29, 91);
            this.lblDescripcionDetalle.Name = "lblDescripcionDetalle";
            this.lblDescripcionDetalle.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcionDetalle.TabIndex = 21;
            this.lblDescripcionDetalle.Text = "Descripción:";
            // 
            // lblNombreDetalle
            // 
            this.lblNombreDetalle.AutoSize = true;
            this.lblNombreDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDetalle.Location = new System.Drawing.Point(29, 38);
            this.lblNombreDetalle.Name = "lblNombreDetalle";
            this.lblNombreDetalle.Size = new System.Drawing.Size(66, 16);
            this.lblNombreDetalle.TabIndex = 18;
            this.lblNombreDetalle.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(29, -15);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código:";
            // 
            // txtMarcaDetalle
            // 
            this.txtMarcaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarcaDetalle.Location = new System.Drawing.Point(141, 138);
            this.txtMarcaDetalle.Name = "txtMarcaDetalle";
            this.txtMarcaDetalle.ReadOnly = true;
            this.txtMarcaDetalle.Size = new System.Drawing.Size(179, 22);
            this.txtMarcaDetalle.TabIndex = 2;
            // 
            // txtCategoriaDetalle
            // 
            this.txtCategoriaDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoriaDetalle.Location = new System.Drawing.Point(141, 194);
            this.txtCategoriaDetalle.Name = "txtCategoriaDetalle";
            this.txtCategoriaDetalle.ReadOnly = true;
            this.txtCategoriaDetalle.Size = new System.Drawing.Size(179, 22);
            this.txtCategoriaDetalle.TabIndex = 3;
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(698, 431);
            this.Controls.Add(this.txtCategoriaDetalle);
            this.Controls.Add(this.txtMarcaDetalle);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.txtDescripcionDetalle);
            this.Controls.Add(this.txtNombreDetalle);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblCategoriaDetalle);
            this.Controls.Add(this.lblMarcaDetalle);
            this.Controls.Add(this.lblDescripcionDetalle);
            this.Controls.Add(this.lblNombreDetalle);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.pbxImagen);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Detalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.TextBox txtDescripcionDetalle;
        private System.Windows.Forms.TextBox txtNombreDetalle;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.Label lblCategoriaDetalle;
        private System.Windows.Forms.Label lblMarcaDetalle;
        private System.Windows.Forms.Label lblDescripcionDetalle;
        private System.Windows.Forms.Label lblNombreDetalle;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtMarcaDetalle;
        private System.Windows.Forms.TextBox txtCategoriaDetalle;
    }
}