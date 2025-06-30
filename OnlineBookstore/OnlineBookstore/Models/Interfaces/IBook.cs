namespace OnlineBookstore.Models.Interfaces
{
    internal interface IBook
    {
        string Title { get; }
        string Author { get; }
        decimal Price { get; }
        int ISBN { get; }
    }
}
