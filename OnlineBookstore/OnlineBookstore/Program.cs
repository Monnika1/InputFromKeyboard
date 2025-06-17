using OnlineBookstore.Models;

namespace OnlineBookstore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookCatalog = new BookCatalog();
            var consoleGenerator = new ConsoleGenerator();

            var ebook = new EBook("The Great Gatsby", "F. Scott Fitzgerald", 10.99m, 97, 1000);
            var ebook2 = new EBook("To Kill a Mockingbird", "Harper Lee", 12.99m, 88, 1500);
            var ebook3 = new EBook("The Catcher in the Rye", "J.D. Salinger", 9.99m, 85, 1200);
            var physBook = new PhysicalBook("1984", "George Orwell", 8.99m, 978035, 70);

            bookCatalog.AddBook(ebook);
            bookCatalog.AddBook(physBook);
            bookCatalog.AddBook(ebook2);
            bookCatalog.AddBook(ebook3);

            var user = new User("John Doe");
            var user2 = new User("Jane Smith");
            var user3 = new User("Alice Johnson");

            PurchaseService purchaseService = new PurchaseService(bookCatalog, consoleGenerator);
            purchaseService.PurchaseBook(user, "The Great Gatsby");
            purchaseService.PurchaseBook(user2, "1984");
            purchaseService.PurchaseBook(user3, "To Kill a Mockingbird");
            purchaseService.PurchaseBook(user, "The Catcher in the Rye");
            consoleGenerator.GenerateReport();

            Console.Read();
        }
    }
}
