using DemoRest.Model.Models;

namespace DemoRest.Server.Data
{
    public class BookContext
    {
        public readonly List<Book> Books;
        public int LastId { get; private set; }
        public BookContext() { 
            Books = new List<Book>();
            LastId = 1;
        }

        public void IncrementId()
        {
            LastId++;
        }
    }
}
