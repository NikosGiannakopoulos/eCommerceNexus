using Microsoft.EntityFrameworkCore;
using eCommerceNexus.Domain.Entities;

namespace eCommerceNexus.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}