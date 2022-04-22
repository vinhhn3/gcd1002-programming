using System;
using System.Collections.Generic;

namespace BookStoreApplication
{
  class BookPresentator
  {
    public BookPresentator()
    {

    }

    public void DisplayBookInfo(Book book)
    {
      Console.WriteLine("============");
      Console.WriteLine($"Book Id: {book.Id}");
      Console.WriteLine($"Book Name: {book.Name}");
      Console.WriteLine($"Author: {book.Author}");
      Console.WriteLine($"Price: {book.Price}");
    }

    public void DisplayBooksInStore(BookStore store)
    {
      Console.WriteLine("====ALL BOOKS IN STORE====");
      foreach (var book in store.Books)
      {
        DisplayBookInfo(book);
      }
    }

    public void DisplayBooks(List<Book> books)
    {
      if (books.Count == 0)
      {
        Console.WriteLine("Nothing Found ...");
      }
      else
      {
        foreach (var book in books)
        {
          DisplayBookInfo(book);
        }
      }
    }
  }
}
