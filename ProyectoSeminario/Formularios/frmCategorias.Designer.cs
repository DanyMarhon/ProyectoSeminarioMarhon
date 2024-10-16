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
            tsbAgregar = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            panelNavegacion = new Panel();
            dgvDatos = new DataGridView();
            colCategorias = new DataGridViewTextBoxColumn();
            colActiva = new DataGridViewTextBoxColumn();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            txtCantidadPaginas = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cboPaginas = new ComboBox();
            tsbFiltrar = new ToolStripButton();
            topTS.SuspendLayout();
            panelNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // topTS
            // 
            topTS.Items.AddRange(new ToolStripItem[] { tsbAgregar, tsbBorrar, tsbEditar, tsbFiltrar });
            topTS.Location = new Point(0, 0);
            topTS.Name = "topTS";
            topTS.Size = new Size(800, 25);
            topTS.TabIndex = 0;
            topTS.Text = "toolStrip1";
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
            // panelNavegacion
            // 
            panelNavegacion.Controls.Add(btnUltimo);
            panelNavegacion.Controls.Add(btnSiguiente);
            panelNavegacion.Controls.Add(btnAnterior);
            panelNavegacion.Controls.Add(btnPrimero);
            panelNavegacion.Controls.Add(txtCantidadPaginas);
            panelNavegacion.Controls.Add(label2);
            panelNavegacion.Controls.Add(label1);
            panelNavegacion.Controls.Add(cboPaginas);
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
            // btnUltimo
            // 
            btnUltimo.Location = new Point(630, 20);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(59, 37);
            btnUltimo.TabIndex = 9;
            btnUltimo.Text = "Ultimo";
            btnUltimo.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(553, 21);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(59, 37);
            btnSiguiente.TabIndex = 10;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(477, 21);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(59, 37);
            btnAnterior.TabIndex = 11;
            btnAnterior.Text = "anterior";
            btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(401, 21);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(59, 37);
            btnPrimero.TabIndex = 12;
            btnPrimero.Text = "primero";
            btnPrimero.UseVisualStyleBackColor = true;
            // 
            // txtCantidadPaginas
            // 
            txtCantidadPaginas.Location = new Point(188, 34);
            txtCantidadPaginas.Name = "txtCantidadPaginas";
            txtCantidadPaginas.Size = new Size(62, 23);
            txtCantidadPaginas.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(162, 37);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 7;
            label2.Text = "de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "Página";
            // 
            // cboPaginas
            // 
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(86, 34);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(72, 23);
            cboPaginas.TabIndex = 5;
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbFiltrar.Image = (Image)resources.GetObject("tsbFiltrar.Image");
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(23, 22);
            tsbFiltrar.Text = "toolStripButton1";
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
            Load += frmCategorias_Load;
            topTS.ResumeLayout(false);
            topTS.PerformLayout();
            panelNavegacion.ResumeLayout(false);
            panelNavegacion.PerformLayout();
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
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private TextBox txtCantidadPaginas;
        private Label label2;
        private Label label1;
        private ComboBox cboPaginas;
        private ToolStripButton tsbFiltrar;
    }
}