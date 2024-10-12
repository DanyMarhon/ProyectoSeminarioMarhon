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
            SuspendLayout();
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(83, 63);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(145, 57);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnCombos
            // 
            btnCombos.Location = new Point(255, 63);
            btnCombos.Name = "btnCombos";
            btnCombos.Size = new Size(145, 57);
            btnCombos.TabIndex = 0;
            btnCombos.Text = "Combos";
            btnCombos.UseVisualStyleBackColor = true;
            // 
            // btnOrdenes
            // 
            btnOrdenes.Location = new Point(83, 163);
            btnOrdenes.Name = "btnOrdenes";
            btnOrdenes.Size = new Size(145, 57);
            btnOrdenes.TabIndex = 0;
            btnOrdenes.Text = "Ordenes";
            btnOrdenes.UseVisualStyleBackColor = true;
            // 
            // btnCategorias
            // 
            btnCategorias.Location = new Point(255, 163);
            btnCategorias.Name = "btnCategorias";
            btnCategorias.Size = new Size(145, 57);
            btnCategorias.TabIndex = 0;
            btnCategorias.Text = "Categorias";
            btnCategorias.UseVisualStyleBackColor = true;
            btnCategorias.Click += btnCategorias_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCategorias);
            Controls.Add(btnOrdenes);
            Controls.Add(btnCombos);
            Controls.Add(btnProductos);
            Name = "frmPrincipal";
            Text = "Carlos Food Truck";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProductos;
        private Button btnCombos;
        private Button btnOrdenes;
        private Button btnCategorias;
    }
}