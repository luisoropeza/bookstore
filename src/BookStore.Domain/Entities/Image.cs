namespace BookStore.Domain.Entities
{
    public class Image
    {
        public int Id { get; set; }
        public string Url { get; set; } = string.Empty;
        public Guid BookId { get; set; }
    }
}
