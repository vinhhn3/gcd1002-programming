
using System.Collections.Generic;
using System.Linq;

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

    public List<Book> SearchBooksByName(string name)
    {
      List<Book> result = Books
        .Where(x => x.Name.Contains(name))
        .ToList();
      return result;
    }

    public List<Book> SearchBooksByAuthorName(string name)
    {
      List<Book> result = Books
        .Where(x => x.Author.Contains(name))
        .ToList();
      return result;
    }

    public Book SearchBookByName(string name)
    {
      var result = Books.FirstOrDefault(x => x.Name == name);
      return result;
    }
    public bool DeleteBookByName(string name)
    {
      var bookInStore = SearchBookByName(name);
      if (bookInStore != null)
      {
        Books.Remove(bookInStore);
        return true;
      }
      return false;
    }
  }
}
