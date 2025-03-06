using Products.Domain.Entities;

namespace Products.Application.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(Guid id);
        Task Upsert(Product product);
        Task Delete(Guid id);
    }
}