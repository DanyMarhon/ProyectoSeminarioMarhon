using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using Dapper;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace ProyectoSeminario.Datos.Repositorios
{
    public class RepositorioProductos : IRepositorioProductos
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

        public List<ProductoListDto> GetLista(SqlConnection conn, SqlTransaction? tran = null)
        {
            var listaProductos = new List<Producto>();

            var selectQuery = @"SELECT * FROM Productos";
            var listaProducto = conn.Query<ProductoListDto>(selectQuery).ToList();
            listaProductos.AddRange(listaProductos);

            return listaProducto;
        }

        public List<Producto> GetListaProductos(SqlConnection conn)
        {
            throw new NotImplementedException();
        }
    }
}
