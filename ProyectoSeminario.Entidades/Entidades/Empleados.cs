using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSeminario.Entidades.Entidades
{
    public class Empleados
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string Clave { get; set; }
        public bool Activo { get; set; }
    }
}
