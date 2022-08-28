namespace AppDiscosDB
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDiscos.Location = new System.Drawing.Point(21, 65);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.RowHeadersWidth = 51;
            this.dgvDiscos.RowTemplate.Height = 24;
            this.dgvDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiscos.Size = new System.Drawing.Size(773, 245);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dgvDiscos_SelectionChanged);
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(810, 65);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(284, 245);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 1;
            this.pbDiscos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(21, 330);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(96, 34);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(141, 330);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(96, 34);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(263, 330);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(127, 34);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar Físico";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(18, 33);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(87, 16);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtro Rápido:";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Location = new System.Drawing.Point(659, 396);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(75, 29);
            this.btnFiltro.TabIndex = 6;
            this.btnFiltro.Text = "Buscar";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(108, 30);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(182, 22);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(18, 402);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(54, 16);
            this.lblCampo.TabIndex = 8;
            this.lblCampo.Text = "Campo:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(78, 398);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(170, 24);
            this.cboCampo.TabIndex = 9;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(254, 402);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(52, 16);
            this.lblCriterio.TabIndex = 10;
            this.lblCriterio.Text = "Criterio:";
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(312, 398);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(143, 24);
            this.cboCriterio.TabIndex = 11;
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(474, 402);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(39, 16);
            this.lblFiltroAvanzado.TabIndex = 12;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(519, 399);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(120, 22);
            this.txtFiltroAvanzado.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 439);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DISCOS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbDiscos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
    }
}

