namespace ProyectoSeminario.Windows.Formularios
{
    partial class frmMenuPrincipal
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
            btnProductos = new Button();
            btnCombos = new Button();
            btnOrdenes = new Button();
            btnCategorias = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            barraTitulo = new Panel();
            btnMinimizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMaximizar = new PictureBox();
            panelContenedorPrincipal = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 15F);
            btnProductos.Location = new Point(0, 189);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(133, 57);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCombos
            // 
            btnCombos.FlatAppearance.BorderSize = 0;
            btnCombos.FlatStyle = FlatStyle.Flat;
            btnCombos.Font = new Font("Segoe UI", 15F);
            btnCombos.Location = new Point(0, 281);
            btnCombos.Name = "btnCombos";
            btnCombos.Size = new Size(133, 57);
            btnCombos.TabIndex = 0;
            btnCombos.Text = "Combos";
            btnCombos.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            btnOrdenes.FlatAppearance.BorderSize = 0;
            btnOrdenes.FlatStyle = FlatStyle.Flat;
            btnOrdenes.Font = new Font("Segoe UI", 15F);
            btnOrdenes.ForeColor = SystemColors.ControlText;
            btnOrdenes.Location = new Point(0, 103);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(133, 57);
            btnOrdenes.TabIndex = 0;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.FlatAppearance.BorderSize = 0;
            btnCategorias.FlatStyle = FlatStyle.Flat;
            btnCategorias.Font = new Font("Segoe UI", 15F);
            btnCategorias.Location = new Point(0, 369);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(133, 57);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCombos);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnOrdenes);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 70);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30.75F, FontStyle.Bold);
            label1.ForeColor = SystemColors.InfoText;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(117, 55);
            label1.TabIndex = 0;
            label1.Text = "C F T";
            // 
            // barraTitulo
            // 
            barraTitulo.BackColor = Color.FromArgb(4, 50, 68);
            barraTitulo.Controls.Add(btnMinimizar);
            barraTitulo.Controls.Add(btnRestaurar);
            barraTitulo.Controls.Add(btnCerrar);
            barraTitulo.Controls.Add(btnMaximizar);
            barraTitulo.Controls.Add(panelContenedorPrincipal);
            barraTitulo.Dock = DockStyle.Top;
            barraTitulo.Location = new Point(0, 0);
            barraTitulo.Name = "barraTitulo";
            barraTitulo.Size = new Size(800, 29);
            barraTitulo.TabIndex = 2;
            barraTitulo.MouseMove += barraTitulo_MouseMove;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.DarkSlateGray;
            btnMinimizar.Image = Properties.Resources.minimizar;
            btnMinimizar.Location = new Point(706, 1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(25, 25);
            btnMinimizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMinimizar.TabIndex = 0;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.BackColor = Color.DarkSlateGray;
            btnRestaurar.Image = Properties.Resources.restaurar;
            btnRestaurar.Location = new Point(737, 1);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(25, 25);
            btnRestaurar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnRestaurar.TabIndex = 0;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.DarkSlateGray;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(768, 1);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(25, 25);
            btnCerrar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnCerrar.TabIndex = 0;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.BackColor = Color.FromArgb(14, 30, 54);
            btnMaximizar.Image = Properties.Resources.maximizar;
            btnMaximizar.Location = new Point(737, 1);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(25, 25);
            btnMaximizar.SizeMode = PictureBoxSizeMode.CenterImage;
            btnMaximizar.TabIndex = 0;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // panelContenedorPrincipal
            // 
            panelContenedorPrincipal.BackColor = Color.DarkSeaGreen;
            panelContenedorPrincipal.Dock = DockStyle.Fill;
            panelContenedorPrincipal.Enabled = false;
            panelContenedorPrincipal.Location = new Point(0, 0);
            panelContenedorPrincipal.Name = "panelContenedorPrincipal";
            panelContenedorPrincipal.Size = new Size(800, 29);
            panelContenedorPrincipal.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 90.75F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(283, 147);
            label2.Name = "label2";
            label2.Size = new Size(344, 161);
            label2.TabIndex = 0;
            label2.Text = "C F T";
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(barraTitulo);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(800, 450);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carlos Food Truck";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnProductos;
        private Button btnCombos;
        private Button btnOrdenes;
        private Button btnCategorias;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel barraTitulo;
        private PictureBox btnRestaurar;
        private PictureBox btnMaximizar;
        private PictureBox btnCerrar;
        private Label label2;
        private PictureBox btnMinimizar;
        private Panel panelContenedorPrincipal;
    }
}