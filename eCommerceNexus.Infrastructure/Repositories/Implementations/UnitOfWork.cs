using eCommerceNexus.Infrastructure.Data;
using eCommerceNexus.Application.Repositories.Interfaces;

namespace eCommerceNexus.Infrastructure.Repositories.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IProductRepository _productRepository;

        public UnitOfWork(ApplicationDbContext applicationDbContext, IProductRepository productRepository)
        {
            _applicationDbContext = applicationDbContext;
            _productRepository = productRepository;
        }

        public IProductRepository ProductRepository => _productRepository;

        public async Task SaveChangesAsync()
        {
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}