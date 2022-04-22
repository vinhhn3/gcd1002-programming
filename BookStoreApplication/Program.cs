using System;

namespace BookStoreApplication
{
  public class Command
  {
    public const int LIST_ALL_BOOK = 1;
    public const int ADD_NEW_BOOK = 2;
    public const int SEARCH_BY_BOOK_NAME = 3;
    public const int EXIT_APPLICATION = 9;
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      BookStore store = new BookStore("Avengers");
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
      Console.WriteLine("9. Exit");
      Console.WriteLine("Please choose your options");


    }
  }
}
