using OnlineBookstore.Models.Interfaces;

namespace OnlineBookstore.Models
{
    internal class BookCatalog : BookCatalogBase
    {
        private List<IBook> books;
    

        public BookCatalog()
        {
            books = new List<IBook>();
        }

        public override void AddBook(IBook book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "Книгата не може да бъде null.");
            }
            if (books.Contains(book))
            {
                throw new ArgumentException("Книгата вече се съдържа в каталога.");
            }
            books.Add(book);
        }
        public override IBook RemoveBook(IBook book)
        {
            if (!books.Contains(book))
            {
                throw new ArgumentException("Книгата не се съдържа в каталога.");
            }
            books.Remove(book);
            return book;
        }

        public override IEnumerable<IBook> GetBooks()
        {
            return books;
        }

        public override IBook GetBookByName(string bookName)
        {
            return books.FirstOrDefault(b => b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase));
        }

        public bool IsEBook(string bookName) 
        {
            IBook book = GetBookByName(bookName);

            return book.GetType() == typeof(EBook);
        }

        internal bool IsAvailable(string bookName, int quantity, decimal price)
        {
            List<IBook> booksWithThatName = books.Where(b => b.Title.Equals(bookName, StringComparison.OrdinalIgnoreCase)).ToList();
            bool isQuantityEnough = booksWithThatName.Count >= quantity;
            return isQuantityEnough;
        }
    }
}
