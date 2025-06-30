using OnlineBookstore.Models.Interfaces;

namespace OnlineBookstore.Models
{
    internal class PurchaseService
    {
        private BookCatalog storeBooks;
        private ConsoleGenerator generator;

        private Dictionary<IUser, IEnumerable<IBook>> userBooks;
        public PurchaseService(BookCatalog catalog, ConsoleGenerator consoleGenerator)
        {
            storeBooks = catalog;
            generator = consoleGenerator;
            userBooks = new Dictionary<IUser, IEnumerable<IBook>>();
        }
        public void PurchaseBook(IUser user, string bookName)
        {
            IBook book = storeBooks.GetBookByName(bookName);
            if (book == null)
            {
                throw new ArgumentException($"Book '{bookName}' not found in the catalog.");
            }

            if (!userBooks.ContainsKey(user))
            {
                userBooks[user] = new List<IBook>();
            }

            userBooks[user] = userBooks[user].Append(book);
            storeBooks.RemoveBook(book);

            generator.Log($"{user.FullName} purchased '{book.Title}'.");

        }

        public void PurchaseBooks(IUser user, List<BookOrder> booksToOrder )
        {
            if (booksToOrder == null)
            {
                throw new ArgumentNullException(nameof(booksToOrder), "The list of books to order cannot be null.");
            }

            decimal totalPrice = 0;

            foreach (BookOrder order in booksToOrder)
            {
                if (!storeBooks.IsAvailable(order.Name, order.Quantity, order.Price))
                {
                    throw new ArgumentException($"Not enough copies of '{order.Name}' available in the catalog.");
                }
                decimal orderPrice = order.Price * order.Quantity;

                if (storeBooks.IsEBook(order.Name))
                {
                    orderPrice *= 0.9m;
                    generator.Log($"EBook '{order.Name}' purchased by {user.FullName} for {orderPrice:C}.");              
                }

                totalPrice += orderPrice;
            }
            bool discount = totalPrice >= 50;
            if (discount)
            {
                totalPrice -= 10m;
                generator.Log($"Total price after discount for {user.FullName} is {totalPrice:C}.");
            }
            else
            {
                generator.Log($"Total price for {user.FullName} is {totalPrice:C}.");
            }
            Console.WriteLine($"Total price for {user.FullName}'s order: {totalPrice:C}.");
        }
        
        public class BookOrder
        {
            public BookOrder(int quantity, string name, decimal price)
            {
                Quantity = quantity;
                Name = name;
                Price = price;
            }
            public int Quantity { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}
