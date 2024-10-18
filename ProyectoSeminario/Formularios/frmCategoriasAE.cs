using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoSeminario.Windows.Formularios
{
    
    public partial class frmCategoriasAE : Form
    {
        private readonly IServiceProvider? _serviceProvider;
        private readonly IServiciosCategorias? _servicio;

        private Categoria? categoria;

        public frmCategoriasAE(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            if (serviceProvider == null)
            {
                throw new ApplicationException("Dependencias no cargadas");
            }
            _serviceProvider = serviceProvider;
            _servicio = _serviceProvider?.GetService<IServiciosCategorias>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categoria is null)
                {
                    categoria  = new Categoria();
                }
                categoria.NombreCategoria = txtNombreCategoria.Text;
                categoria.Activa = true;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                valido = false;
                errorProvider1.SetError(txtNombreCategoria, "Nombre de caja es requerido");
            }
            return valido;
        }

        public void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
        public Categoria? GetCategoria()
        {
            return categoria;
        }
    }
}
