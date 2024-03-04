using Microsoft.Extensions.DependencyInjection;
using eCommerceNexus.Application.Services.Interfaces;
using eCommerceNexus.Application.Services.Implementations;

namespace eCommerceNexus.Application.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();

            return services;
        }
    }
}