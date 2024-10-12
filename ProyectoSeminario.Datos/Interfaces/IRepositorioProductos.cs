using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioProductos
    {
        List<ProductoListDto> GetLista(SqlConnection conn, int currentPage, int pageSize, Categoria categoria, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null);
        int GetCantidad(SqlConnection conn, Categoria categoria, Func<ProductoListDto, bool>? filter = null, SqlTransaction? tran = null);
        void Borrar(Categoria categoria, int ProductoId, SqlConnection conn, SqlTransaction tran);
        bool Existe(Producto producto, SqlConnection conn);
        void Agregar(Producto producto, SqlConnection conn, SqlTransaction tran);
        void Editar(Producto producto, SqlConnection conn, SqlTransaction tran);
        List<Producto> GetListaProductos(SqlConnection conn);
    }
}
