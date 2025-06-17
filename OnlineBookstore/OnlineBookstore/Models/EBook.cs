using OnlineBookstore.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookstore.Models
{
    internal class EBook : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public decimal Price { get; }
        public int ISBN { get; }
        public int FileSize { get; }

    

        public EBook(string title, string author, decimal price, int isbn, int fileSize)
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
            FileSize = fileSize;
        }
        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Price: {Price:C}, Size: {FileSize / 1024} KB";
        }
    }
}
