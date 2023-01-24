using DemoRest.Model.Models;

namespace DemoRest.Client.Services
{
    public class BookService : IBookService
    {
        private readonly IHttpService _httpService;
        public BookService(IHttpService httpService) {
            _httpService = httpService;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _httpService.GetFromJsonAsync<List<Book>>("api/book/getbooks");
        }

        public async Task AddBookAsync(BookFormInput bookFormInput)
        {
            await _httpService.PostAsJsonAsync("api/book/addbook", bookFormInput);
        }
    }
}
