namespace eCommerceNexus.Application.Repositories.Interfaces.Generics
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(TKey id);
        Task UpsertAsync(TEntity entity);
        Task DeleteAsync(TKey id);
    }
}