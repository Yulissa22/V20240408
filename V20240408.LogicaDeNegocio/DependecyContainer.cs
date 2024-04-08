using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using V20240408.AccesoADatos;
using V20240408.EntidadesDeNegocio;

namespace V20240408.LogicaDeNegocio
{
    public static class DependecyContainer
    {
        public static IServiceCollection AddBLDependecies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDALDependecies(configuration);
            services.AddScoped<PersonaBL>();
            return services;
        }

        
    }
}
