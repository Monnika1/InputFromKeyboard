using OnlineBookstore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

    }
}
