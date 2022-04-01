using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Create a list of string type
      List<string> names = new List<string>();

      // Add items to list
      names.Add("John Doe");
      names.Add("John Wick");
      names.Add("Vladimir Putin");
      names.Add("Joe Biden");

      // Use for loop to display all items of a list
      Console.WriteLine("===For loop===");
      for (int i = 0; i < names.Count - 1; i++)
      {
        Console.WriteLine(names[i]);
      }

      // Use foreach loop to display all items of a list
      Console.WriteLine("===Foreach loop===");
      foreach (var item in names)
      {
        Console.WriteLine(item);
      }

      // Remove an item
      names.Remove("John Doe");
      Console.WriteLine("===After remove an Item===");
      foreach (var item in names)
      {
        Console.WriteLine(item);
      }

      // Sort
      List<int> numbers = new List<int>
      {
        1,2,-1,-5,5,9,10,20
      };

      numbers.Sort();
      Console.WriteLine("Sort the array...");
      foreach (var item in numbers)
      {
        Console.WriteLine(item);
      }

      // Search
      Console.WriteLine("Enter a number n");
      int n = int.Parse(Console.ReadLine());

      if (numbers.Contains(n))
      {
        Console.WriteLine($"{n} is an item of the list numbers");
      }
      else
      {
        Console.WriteLine($"{n} is not an item of the list numbers");
      }

      // Reading lists from console
      string inputLine = Console.ReadLine();

      // First Method
      string[] arrInputLine = inputLine.Split();

      List<int> listInt = new List<int>();
      foreach (var item in arrInputLine)
      {
        listInt.Add(int.Parse(item));
      }

      // Second Method using LINQ
      listInt = Console.ReadLine()
                  .Split()
                  .Select(int.Parse)
                  .ToList();

      // Reverse an Array
      numbers = new List<int>
      {
        1,2,3,4,5,6,7,8,9,10
      };
      numbers.Reverse();
      foreach (var item in numbers)
      {
        Console.WriteLine(item);
      }
    }
  }
}
