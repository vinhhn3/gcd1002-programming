using System.Collections.Generic;

namespace BookStoreApplication
{
  class BookStore
  {
    public List<Book> Books { get; private set; }
    public string Name { get; private set; }
    private BookStore()
    {

    }
    public BookStore(string name)
    {
      Name = name;
      Books = new List<Book>();
    }

    public void AddBook(string name, string author, double price)
    {
      Book newBook = new Book(Books.Count + 1, name, author, price);
      Books.Add(newBook);
    }
  }
}
