using BookStore.Application.DataTransferObjects.ImageDto;

namespace BookStore.Application.DataTransferObjects.BookDto
{
    public class BookRequest
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public int AuthorId { get; set; }
        public IEnumerable<ImageRequest> Images { get; set; } = [];
    }

    public class BookAddDiscountRequest
    {
        public int Discount { get; set; }
    }

    public class BookAddStockRequest
    {
        public int Stock { get; set; }
    }
}
