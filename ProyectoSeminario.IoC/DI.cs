using ProyectoSeminario.Datos.Interfaces;
using ProyectoSeminario.Datos.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;

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


            //service.AddScoped<IServiciosProvinciasEstados, ServiciosProvinciasEstados>();


            //service.AddScoped<IServiciosPaises>(sp => {
            //    var repositorio = new RepositorioPaises();
            //    return new ServiciosPaises(repositorio, cadena);
            //});

            return service.BuildServiceProvider();
        }
    }
}
