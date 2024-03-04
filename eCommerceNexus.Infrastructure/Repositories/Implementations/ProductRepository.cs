using eCommerceNexus.Domain.Entities;
using eCommerceNexus.Infrastructure.Data;
using eCommerceNexus.Application.Repositories.Interfaces;
using eCommerceNexus.Infrastructure.Repositories.Implementations.Generics;

namespace eCommerceNexus.Infrastructure.Repositories.Implementations
{
    public class ProductRepository : GenericRepository<Product, int>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext) { }
    }
}