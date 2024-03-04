using Microsoft.EntityFrameworkCore;
using eCommerceNexus.Infrastructure.Data;
using eCommerceNexus.Application.Repositories.Interfaces.Generics;

namespace eCommerceNexus.Infrastructure.Repositories.Implementations.Generics
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _applicationDbContext.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(TKey id)
        {
            return await _applicationDbContext.Set<TEntity>().FindAsync(id);
        }

        public async Task UpsertAsync(TEntity entity)
        {
            if (_applicationDbContext.Entry(entity).State == EntityState.Detached)
            {
                _applicationDbContext.Set<TEntity>().Add(entity);
            }
            else
            {
                _applicationDbContext.Set<TEntity>().Update(entity);
            }
        }

        public async Task DeleteAsync(TKey id)
        {
            var entity = await _applicationDbContext.Set<TEntity>().FindAsync(id);

            if (entity != null)
            {
                _applicationDbContext.Set<TEntity>().Remove(entity);
            }
        }
    }
}