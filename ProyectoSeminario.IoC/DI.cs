using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Datos.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using ProyectoSeminario.Servicios.Interfaces;
using ProyectoSeminario.Servicios.Servicios;

namespace ProyectoSeminario.IoC
{
    public static class DI
    {
        public static IServiceProvider ConfigurarServicios()
        {
            var service = new ServiceCollection();

            var cadena = ConfigurationManager
                .ConnectionStrings["MiConexion"].ToString();

            service.AddScoped<IRepositorioProductos, RepositorioProductos>();

            service.AddScoped<IServiciosProductos, ServiciosProductos>();


            //service.AddScoped<IServiciosPaises>(sp => {
            //    var repositorio = new RepositorioPaises();
            //    return new ServiciosPaises(repositorio, cadena);
            //});

            return service.BuildServiceProvider();
        }
    }
}
