using OnlineBookstore.Models.Interfaces;

namespace OnlineBookstore.Models
{
    internal class PhysicalBook : IBook
    {
        public string Title { get; }
        public string Author { get;  }
        public decimal Price { get; }
        public int ISBN { get; }

        public decimal ShippingWeight { get; }


        public PhysicalBook(string title, string author, decimal price, int isbn, decimal shippingWeight)
        {
            Title = title;
            Author = author;
            Price = price;
            ISBN = isbn;
            ShippingWeight = shippingWeight;
        }

        public override string ToString()
        {
            return $"{Title} by {Author}, ISBN: {ISBN}, Shipping Weight: {ShippingWeight:C}";
        }
    }
}
