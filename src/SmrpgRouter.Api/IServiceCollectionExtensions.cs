using Microsoft.Extensions.DependencyInjection;
using SmrpgRouter.DAL;
using SmrpgRouter.Domain;

namespace SmrpgRouter.Web
{
    public static class IServiceCollectionExtensions
    {
        public static void BootstrapDependencies(this IServiceCollection services)
        {
            services.AddScoped<CharacterRepository>();
            services.AddScoped<SmrpgContext>();
        }
    }
}
