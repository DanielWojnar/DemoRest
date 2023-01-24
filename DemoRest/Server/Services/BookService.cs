using AutoMapper;
using DemoRest.Model.Models;
using DemoRest.Server.Data;

namespace DemoRest.Server.Services
{
    public class BookService : IBookService
    {
        private readonly BookContext _bookContext;
        private readonly IMapper _mapper;
        public BookService(BookContext bookContext, IMapper mapper) {
            _bookContext = bookContext;
            _mapper = mapper;
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return _bookContext.Books;
        }

        public async Task AddBookAsync(BookFormInput bookFormInput)
        {
            var book = _mapper.Map<Book>(bookFormInput);
            book.Id = _bookContext.LastId;
            _bookContext.Books.Add(book);
            _bookContext.IncrementId();
        }
    }
}
