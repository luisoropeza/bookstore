namespace BookStore.Domain.Entities
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        public double Price { get; set; }
        public int Stock { get; set; }
        public double Discount { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; } = default!;
        public ICollection<Image> Images { get; set; } = [];
    }
}
