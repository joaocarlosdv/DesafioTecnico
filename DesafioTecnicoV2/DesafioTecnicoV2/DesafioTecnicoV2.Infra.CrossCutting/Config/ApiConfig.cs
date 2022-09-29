using DesafioTecnicoV2.Service.Services;
using DesafioTecnicoV2.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace DesafioTecnicoV2.Infra.CrossCutting.Config
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
