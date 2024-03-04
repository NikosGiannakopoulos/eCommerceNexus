using Microsoft.EntityFrameworkCore;
using eCommerceNexus.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using eCommerceNexus.Application.Repositories.Interfaces;
using eCommerceNexus.Infrastructure.Repositories.Implementations;
using eCommerceNexus.Application.Repositories.Interfaces.Generics;
using eCommerceNexus.Infrastructure.Repositories.Implementations.Generics;

namespace eCommerceNexus.Infrastructure.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("eCommerceNexus.Infrastructure")));

            services.AddScoped(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}