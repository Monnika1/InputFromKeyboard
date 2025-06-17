using OnlineBookstore.Models.Interfaces;

namespace OnlineBookstore.Models
{
    abstract class BookCatalogBase
    {
        public abstract void AddBook(IBook book);
        public abstract IBook RemoveBook(IBook book);
        public abstract IEnumerable<IBook> GetBooks();
        public abstract IBook GetBookByName(string bookName);
    }
}