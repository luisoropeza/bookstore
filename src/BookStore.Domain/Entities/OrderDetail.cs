namespace BookStore.Domain.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public Guid OrderId { get; set; }
        public Order Order { get; set; } = default!;
        public Guid BookId { get; set; }
        public Book Book { get; set; } = default!;
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
