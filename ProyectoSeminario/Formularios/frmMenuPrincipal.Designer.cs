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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnProductos
            // 
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
            btnCombos.Location = new Point(0, 281);
            btnCombos.Name = "btnCombos";
            btnCombos.Size = new Size(133, 57);
            btnCombos.TabIndex = 0;
            btnCombos.Text = "Combos";
            btnCombos.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(0, 103);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(133, 57);
            btnOrdenes.TabIndex = 0;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
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
            panel1.BackColor = Color.FromArgb(14, 30, 54);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCombos);
            panel1.Controls.Add(btnCategorias);
            panel1.Controls.Add(btnProductos);
            panel1.Controls.Add(btnOrdenes);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(133, 450);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(133, 82);
            panel2.TabIndex = 0;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "frmMenuPrincipal";
            Text = "Carlos Food Truck";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnCombos;
        private Button btnOrdenes;
        private Button btnCategorias;
        private Panel panel1;
        private Panel panel2;
    }
}