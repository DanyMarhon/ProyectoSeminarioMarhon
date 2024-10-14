using Dapper;
using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioCategorias : IRepositorioCategorias
    {
        public void Agregar(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            throw new NotImplementedException();
        }

        public int GetCategoriaIdIfExists(Categoria categoria, SqlConnection conn, SqlTransaction? tran = null)
        {
            var selectQuery = @"SELECT CategoriaId FROM Categorias 
                WHERE NombreCategoria = @NombreCategoria";
            return conn.ExecuteScalar<int>(selectQuery, categoria, tran);
        }

        public Categoria? GetCategoriaPorId(int categoriaId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = "SELECT * FROM Categorias WHERE CategoriaId = @CategoriaId";
            return conn.QuerySingleOrDefault<Categoria>(query, new { CategoriaId = categoriaId }, tran);
        }

        public List<Categoria> GetCategoriaPorProductoId(int productoId, SqlConnection conn, SqlTransaction? tran = null)
        {
            var query = @"
            SELECT * 
            FROM Categorias c
            JOIN Productos p ON c.CategoriaId = p.CategoriaId
            WHERE p.CategoriaId = @CategoriaId
        ";
            return conn.Query<Categoria>(query, new { ProductoId = productoId }, tran).ToList();
        }
    }
}
