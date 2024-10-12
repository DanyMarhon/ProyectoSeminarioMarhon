using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades.Entidades
{
    public class Categoria
    {
        public int IdCategoria { get; set; }
        public required string NombreCategoria { get; set; }
        public bool Activa { get; set; }
    }
}
