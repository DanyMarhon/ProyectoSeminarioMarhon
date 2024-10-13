using ProyectoSeminario.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades.Dtos
{
    public class ProductoListDto
    {
        public string Nombre { get; set; } = null!;
        public decimal PrecioVenta { get; set; }
        public string Categoria { get; set; }
    }
}
