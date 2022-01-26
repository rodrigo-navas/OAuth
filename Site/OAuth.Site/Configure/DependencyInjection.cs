using Microsoft.Extensions.DependencyInjection;
using OAuth.Domain.Interfaces;
using OAuth.Domain.Services;

namespace OAuth.Site.Configure
{
    public static class DependencyInjection
    {
        public static IServiceCollection ConfigureSite(this IServiceCollection services)
        {
            services.AddScoped<IMinhaContaService, MinhaContaService>();
            return services;
        }
    }
}
