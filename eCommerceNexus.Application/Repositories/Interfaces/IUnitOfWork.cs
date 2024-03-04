namespace eCommerceNexus.Application.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        Task SaveChangesAsync();
    }
}