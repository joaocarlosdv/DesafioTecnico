using DesafioTecnico.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnico.Configuration
{
    public static class ApiConfig
    {
        public static IServiceCollection ApiConfiServices(this IServiceCollection services)
        {
            #region Services
            services.AddScoped<IFamiliaService, FamiliaService>();
            #endregion Services

            return services;
        }
    }
}
