using BookStore.Domain.Enums;

namespace BookStore.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; } = default!;
        public double TotalAmount { get; set; }
        public double TotalFee { get; set; }
        public EOrderStatus Status { get; set; } = EOrderStatus.Pending;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
        public ICollection<OrderDetail> Details { get; set; } = [];
    }
}
