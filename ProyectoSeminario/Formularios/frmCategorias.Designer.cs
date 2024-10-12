namespace ProyectoSeminario.Windows.Formularios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            topTS = new ToolStrip();
            panelNavegacion = new Panel();
            dgvDatos = new DataGridView();
            tsbAgregar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            colCategorias = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewTextBoxColumn();
            topTS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // topTS
            // 
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbBorrar, tsbEditar });
            topTS.Location = new Point(0, 0);
            topTS.Name = "topTS";
            topTS.Size = new Size(800, 25);
            topTS.TabIndex = 0;
            topTS.Text = "toolStrip1";
            // 
            // panelNavegacion
            // 
            panelNavegacion.Dock = DockStyle.Bottom;
            panelNavegacion.Location = new Point(0, 367);
            panelNavegacion.Name = "panelNavegacion";
            panelNavegacion.Size = new Size(800, 83);
            panelNavegacion.TabIndex = 1;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colCategorias, colActiva });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 25);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.Size = new Size(800, 342);
            dgvDatos.TabIndex = 2;
            // 
            // tsbAgregar
            // 
            tsbAgregar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbAgregar.Image = (Image)resources.GetObject("tsbAgregar.Image");
            tsbAgregar.ImageTransparentColor = Color.Magenta;
            tsbAgregar.Name = "tsbAgregar";
            tsbAgregar.Size = new Size(23, 22);
            tsbAgregar.Text = "toolStripButton1";
            // 
            // tsbBorrar
            // 
            tsbBorrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBorrar.Image = (Image)resources.GetObject("tsbBorrar.Image");
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(23, 22);
            tsbBorrar.Text = "toolStripButton1";
            // 
            // tsbEditar
            // 
            tsbEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEditar.Image = (Image)resources.GetObject("tsbEditar.Image");
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(23, 22);
            tsbEditar.Text = "toolStripButton1";
            // 
            // colCategorias
            // 
            colCategorias.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCategorias.FillWeight = 159.390884F;
            colCategorias.HeaderText = "Categorías";
            colCategorias.Name = "colCategorias";
            colCategorias.ReadOnly = true;
            // 
            // colActiva
            // 
            colActiva.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colActiva.FillWeight = 40.6091423F;
            colActiva.HeaderText = "Activa";
            colActiva.Name = "colActiva";
            colActiva.ReadOnly = true;
            // 
            // frmCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvDatos);
            Controls.Add(panelNavegacion);
            Controls.Add(topTS);
            Name = "frmCategorias";
            Text = "frmCategorias";
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip topTS;
        private ToolStripButton tsbAgregar;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private Panel panelNavegacion;
        private DataGridView dgvDatos;
        private DataGridViewTextBoxColumn colCategorias;
        private DataGridViewTextBoxColumn colActiva;
    }
}