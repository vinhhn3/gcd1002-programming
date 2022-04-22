namespace BookStoreApplication
{
  internal class Program
  {
    static void Main(string[] args)
    {
      BookStore store = new BookStore("Avengers");
      BookPresentator presentator = new BookPresentator();
      Book book = new Book(1, "C# Basic 1", "Kent Beck", 123);
      presentator.DisplayBookInfo(book);

      store.AddBook("C# Basic 2", "Kent Beck", 123);
      store.AddBook("C# Intermediate", "Kent Beck", 234);
      store.AddBook("C# Advanced 1", "Kent Beck", 345);
      store.AddBook("C# Advanced 2", "Kent Beck", 456);

      presentator.DisplayBooksInStore(store);

    }
  }
}
