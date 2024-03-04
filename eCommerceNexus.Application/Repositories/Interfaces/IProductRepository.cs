using eCommerceNexus.Domain.Entities;
using eCommerceNexus.Application.Repositories.Interfaces.Generics;

namespace eCommerceNexus.Application.Repositories.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product, int>
    {

    }
}