using DemoRest.Model.Models;
using DemoRest.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoRest.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetBooks")]
        public async Task<IActionResult> GetBooks()
        {
            var result = await _bookService.GetBooksAsync();
            return Ok(result);
        }
        [HttpPost]
        [Route("AddBook")]
        public async Task<IActionResult> AddBook([FromBody] BookFormInput bookFormInput)
        {
            await _bookService.AddBookAsync(bookFormInput);
            return Ok();
        }
    }   
}
