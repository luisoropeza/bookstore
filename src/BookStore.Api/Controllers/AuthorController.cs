using BookStore.Application.DataTransferObjects.AuthorDto;
using BookStore.Application.Services.AuthorService;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthorController(IAuthorService service) : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAllAuthorsAsync()
        {
            return Ok(await service.GetAllAuthorsAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorByIdAsync(int id)
        {
            return Ok(await service.GetAuthorByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> CreateAuthorAsync(AuthorRequest request)
        {
            await service.CreateAuthorAsync(request);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthorAsync(int id, AuthorRequest request)
        {
            await service.UpdateAuhorAsync(id, request);
            return NoContent();
        }
    }
}
