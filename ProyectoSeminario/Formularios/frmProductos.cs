using Microsoft.Extensions.DependencyInjection;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Windows.Helpers;
using System.Data.SqlClient;

namespace ProyectoSeminario.Windows.Formularios
{
    public partial class frmProductos : Form
    {
        private List<ProductoListDto> lista = null!;
        private readonly IServiciosProductos? _servicio;
        private readonly IServiceProvider? _serviceProvider;

        private int currentPage = 1;//pagina actual
        private int totalPages = 0;//total de paginas
        private int pageSize = 10;//registros por página
        private int totalRecords = 0;//cantidad de registros

        public frmProductos(IServiceProvider? serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _servicio = serviceProvider?.GetService<IServiciosProductos>()
                ?? throw new ApplicationException("Dependencias no cargadas!!!"); ;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            RecargarGrilla();
        }

        private void RecargarGrilla()
        {
            try
            {
                
                    lista = _servicio!.GetLista();
                    MostrarDatosEnGrilla(lista);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al recargar la grilla: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void MostrarDatosEnGrilla(List<ProductoListDto> lista)
        {
            GridHelper.LimpiarGrilla(dgvDatos);
            if (lista is not null)
            {
                foreach (var c in lista)
                {
                    var r = GridHelper.ConstruirFila(dgvDatos);
                    GridHelper.SetearFila(r, c);
                    GridHelper.AgregarFila(dgvDatos, r);
                }

            }
        }

        private void LoadData(Func<ProductoListDto, bool>? filter = null)
        {
            try
            {
                using (var conn = new SqlConnection())
                {
                    conn.Open();
                    lista = _servicio!.GetLista();
                    MostrarDatosEnGrilla(lista);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
