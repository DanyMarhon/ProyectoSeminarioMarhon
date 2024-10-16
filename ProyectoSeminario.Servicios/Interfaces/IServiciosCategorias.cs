using ProyectoSeminario.Entidades.Dtos;
using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Servicios.Interfaces
{
    public interface IServiciosCategorias
    {
        void Borrar(int categoriaId);
        //bool EstaRelacionado(int productoId);
        bool Existe(Categoria categoria);
        List<CategoriaListDto> GetLista(int currentPage, int pageSize, Func<CategoriaListDto, bool>? filter = null);
        void Guardar(Categoria categoria);
        Categoria? GetCategoriaPorId(int categoriaId);
        int GetCantidad(Func<CategoriaListDto, bool>? filter = null);
    }
}
