using DemoRest.Model.Models;

namespace DemoRest.Client.Services
{
    public interface IBookService
    {
        public Task<List<Book>> GetBooksAsync();
        public Task AddBookAsync(BookFormInput bookFormInput);
    }
}
