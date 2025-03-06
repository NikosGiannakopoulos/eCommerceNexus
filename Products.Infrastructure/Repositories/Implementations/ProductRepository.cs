using Products.Domain.Entities;
using Products.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Products.Application.Repositories.Interfaces;

namespace Products.Infrastructure.Repositories.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext context;

        public ProductRepository(ProductDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }

        public async Task<Product> GetById(Guid id)
        {
            return await context.Products.FindAsync(id);
        }

        public async Task Upsert(Product product)
        {
            var existingProduct = await context.Products.FindAsync(product.Id);

            if (existingProduct == null)
                await context.Products.AddAsync(product);
            else
                context.Entry(existingProduct).CurrentValues.SetValues(product);

            await context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var existingProduct = await context.Products.FindAsync(id);

            if (existingProduct != null)
            {
                context.Products.Remove(existingProduct);
                await context.SaveChangesAsync();
            }
        }
    }
}