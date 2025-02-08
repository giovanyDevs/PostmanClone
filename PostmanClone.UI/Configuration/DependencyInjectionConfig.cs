using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PostmanClone.UI.FormUI;

namespace PostmanClone.UI.Configuration
{
    internal static class DependencyInjectionConfig
    {
        internal static IServiceCollection AddUIDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<Dashboard>();

            return services;
        }
    }
}
