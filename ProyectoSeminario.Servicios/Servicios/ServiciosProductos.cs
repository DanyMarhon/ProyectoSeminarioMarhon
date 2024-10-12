using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using ProyectoSeminario.Servicios.Interfaces;
using System.Data.SqlClient;

namespace ProyectoSeminario.Servicios.Servicios
{
    public class ServiciosProductos : IServiciosProductos

    {
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

        public int GetCantidad(SqlConnection conn, Categoria categoria, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Categoria categoria, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public List<Producto> GetListaProductos(SqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
