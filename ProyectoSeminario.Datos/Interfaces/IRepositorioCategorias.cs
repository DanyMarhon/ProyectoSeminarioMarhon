using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Datos.Interfaces
{
    public interface IRepositorioCategorias
    {
        int GetCategoriaIdIfExists(Categoria categoria, SqlConnection conn,
            SqlTransaction? tran = null);

        void Agregar(Categoria categoria, SqlConnection conn,
            SqlTransaction? tran = null);
        Categoria? GetCategoriaPorId(int categoriaId, SqlConnection conn,
            SqlTransaction? tran = null);
        List<Categoria> GetCategoriaPorProductoId(int productoId,
            SqlConnection conn, SqlTransaction? tran = null);
    }
}
