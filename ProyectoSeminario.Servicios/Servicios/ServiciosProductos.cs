using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.Data.SqlClient;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos
    {
        private readonly IRepositorioProductos? _repositorio;
        private readonly string? _cadena;
        public ServiciosProductos(IRepositorioProductos? repositorio, string? cadena)
        {
            _repositorio = repositorio ?? throw new ApplicationException("Dependencias no cargadas!!!");
            _cadena = cadena;
        }
        public void Agregar(Producto producto, SqlConnection conn, SqlTransaction tran)
        {
            throw new NotImplementedException();
        }

        public void Borrar(Categoria categoria, int ProductoId, SqlConnection conn, SqlTransaction tran)
        {
            throw new NotImplementedException();
        }

        public void Editar(Producto producto, SqlConnection conn, SqlTransaction tran)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Producto producto, SqlConnection conn)
        {
            throw new NotImplementedException();
        }

        public int GetCantidad(SqlConnection conn, SqlTransaction? tran = null)
        {
            try
            {
                int cantidad = 0;
                using (conn = new SqlConnection())
                {
                    conn.Open();
                    string selectQuery = "SELECT COUNT(*) FROM Productos";
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ProductoListDto> GetLista()
        {
            using (var conn = new SqlConnection())
            {
                conn.Open();
                return _repositorio!.GetLista(conn);
            }
        }

        public List<Producto> GetListaProductos(SqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
