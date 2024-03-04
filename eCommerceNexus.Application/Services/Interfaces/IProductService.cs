using eCommerceNexus.Domain.Entities;

namespace eCommerceNexus.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task UpsertProductAsync(Product product);
        Task DeleteProductAsync(int id);
    }
}