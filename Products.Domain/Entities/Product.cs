using Products.Domain.Entities.Enums;

namespace Products.Domain.Entities
{
    class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public Status Status { get; set; }
        public List<string> ImageUrls { get; set; }
        public List<Review> Reviews { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}