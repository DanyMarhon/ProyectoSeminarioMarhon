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
            service.AddScoped<IRepositorioCategorias, RepositorioCategorias>();


            service.AddScoped<IServiciosProductos>(sp =>
            {
                var repositorio = new RepositorioProductos();
                var repositorioCategorias = new RepositorioCategorias();
                return new ServiciosProductos(repositorio, cadena);
            });

            service.AddScoped<IServiciosCategorias>(sp =>
            {
                var repositorio = new RepositorioCategorias();
                var repositorioCategorias = new RepositorioCategorias();
                return new ServiciosCategorias(repositorio, cadena);
            });

            return service.BuildServiceProvider();
        }
    }
}
