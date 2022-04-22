using System;

namespace BookStoreApplication
{
  public class Command
  {
    public const int LIST_ALL_BOOK = 1;
    public const int ADD_NEW_BOOK = 2;
    public const int SEARCH_BY_BOOK_NAME = 3;
    public const int SEARCH_BY_AUTHOR_NAME = 4;
    public const int UPDATE_BOOK_BY_NAME = 5;
    public const int EXIT_APPLICATION = 9;
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      BookStore store = new BookStore("Avengers");
      LoadBooks(store);
      BookPresentator presentator = new BookPresentator();
      DisplayMenu();
      int command = int.Parse(Console.ReadLine());
      while (command != Command.EXIT_APPLICATION)
      {
        switch (command)
        {
          case Command.LIST_ALL_BOOK:
            presentator.DisplayBooksInStore(store);
            break;
          case Command.ADD_NEW_BOOK:
            Console.WriteLine("Enter book name: ");
            string bookName = Console.ReadLine();
            Console.WriteLine("Enter book author: ");
            string bookAuthor = Console.ReadLine();
            Console.WriteLine("Enter book price: ");
            double bookPrice = double.Parse(Console.ReadLine());
            store.AddBook(bookName, bookAuthor, bookPrice);
            Console.WriteLine("Book added successfully ...");
            break;
          case Command.SEARCH_BY_BOOK_NAME:
            Console.WriteLine("Enter search book name: ");
            string searchName = Console.ReadLine();
            var books = store.SearchBooksByName(searchName);
            presentator.DisplayBooks(books);
            break;
          case Command.SEARCH_BY_AUTHOR_NAME:
            Console.WriteLine("Enter author book name: ");
            string searchAuthor = Console.ReadLine();
            var booksResult = store.SearchBooksByAuthorName(searchAuthor);
            presentator.DisplayBooks(booksResult);
            break;
          case Command.UPDATE_BOOK_BY_NAME:
            Console.WriteLine("Enter book name to update");
            string updateBookName = Console.ReadLine();
            Book bookInStore = store.SearchBookByName(updateBookName);
            if (bookInStore == null)
            {
              Console.WriteLine("Book Not Found ...");
              break;
            }
            else
            {
              Console.WriteLine(("Enter New Book Name:"));
              string newName = Console.ReadLine();
              Console.WriteLine(("Enter New Author Name:"));
              string newAuthor = Console.ReadLine(); Console.WriteLine(("Enter New Book Name:"));
              Console.WriteLine(("Enter New Price:"));
              double newPrice = double.Parse(Console.ReadLine());
              bookInStore.Name = newName;
              bookInStore.Author = newAuthor;
              bookInStore.Price = newPrice;
            }
            break;

          case Command.EXIT_APPLICATION:
            return;
          default:
            break;
        }
        DisplayMenu();
        command = int.Parse(Console.ReadLine());
      }
    }

    public static void DisplayMenu()
    {
      Console.WriteLine("====BOOK STORE APPLICATION====");
      Console.WriteLine("1. Display all books in Store");
      Console.WriteLine("2. Add a new book to store");
      Console.WriteLine("3. Search book by name");
      Console.WriteLine("4. Search book by author name");
      Console.WriteLine("5. Update book by name");
      Console.WriteLine("9. Exit");
      Console.WriteLine("Please choose your options");
    }

    public static void LoadBooks(BookStore store)
    {
      store.AddBook("C# Basic", "Kent Beck", 123);
      store.AddBook("C# Advanced 1", "Kent Beck", 345);
      store.AddBook("C# Advanced 2", "Kent Beck", 555);
      store.AddBook("PHP Basic", "John Wick", 222);
      store.AddBook("Symfony Framework", "John Doe", 555);
    }

  }
}
