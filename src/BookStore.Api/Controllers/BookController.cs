using BookStore.Application.DataTransferObjects.BookDto;
using BookStore.Application.Services.BookService;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController(IBookService service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllBooksAsync()
        {
            return Ok(await service.GetAllBooksAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookByIdAsync(Guid id)
        {
            return Ok(await service.GetBookByIdAsync(id));
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchBooksByTitleAsync(string title)
        {
            return Ok(await service.SearchBooksByTitleAsync(title));
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook(BookRequest request)
        {
            await service.CreateBookAsync(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookAsync(Guid id, BookRequest request)
        {
            await service.UpdateBookAsync(id, request);
            return NoContent();
        }

        [HttpPatch("discount/add/{id}")]
        public async Task<IActionResult> AddDiscountAsync(Guid id, BookAddDiscountRequest request)
        {
            await service.AddDiscountAsync(id, request);
            return NoContent();
        }

        [HttpPatch("discount/remove/{id}")]
        public async Task<IActionResult> RemoveDiscountAsync(Guid id)
        {
            await service.RemoveDiscountAsync(id);
            return NoContent();
        }

        [HttpPost("stock/add/{id}")]
        public async Task<IActionResult> AddStockAsync(Guid id, BookAddStockRequest request)
        {
            await service.AddStockAsync(id, request);
            return NoContent();
        }
    }
}
