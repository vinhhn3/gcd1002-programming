using System;
using System.Linq;

namespace Arrays
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Create an double array
      // Length = 5
      // maxIndex = Length - 1 = 5 - 1 = 4
      double[] marks = new double[5];

      // Assign value to array
      marks[0] = 10.2;
      marks[1] = 20.3;
      marks[2] = 21.3;
      marks[3] = 22.3;
      marks[4] = 33.3;
      // marks[10] = 33; IndexOutRangeException

      // Print all values of an Array
      for (int i = 0; i < marks.Length; i++)
      {
        Console.WriteLine($"marks[{i}] = {marks[i]}");
      }

      // Enter a day number [1...7] and
      // print the day name (in English) or "Invalid day!"

      // Create an array that stores days of a week
      string[] daysOfWeek = new string[7];
      daysOfWeek[0] = "Monday";
      daysOfWeek[1] = "Tuesday";
      daysOfWeek[2] = "Wednesday";
      daysOfWeek[3] = "Thursday";
      daysOfWeek[4] = "Friday";
      daysOfWeek[5] = "Saturday";
      daysOfWeek[6] = "Sunday";

      Console.WriteLine("Enter a day number [1...7] ");
      int dayNumber = int.Parse(Console.ReadLine());

      if (dayNumber < 1 || dayNumber > 7)
      {
        Console.WriteLine("Invalid day ...");
      }
      else
      {
        Console.WriteLine(daysOfWeek[dayNumber - 1]);
      }

      // Reading a string
      // Convert it to an integer array
      // First method
      Console.WriteLine("Enter values: ");
      string values = Console.ReadLine();

      string[] arrayValues = values.Split();

      int[] arrayInt = new int[arrayValues.Length];

      for (int i = 0; i < arrayInt.Length; i++)
      {
        arrayInt[i] = int.Parse(arrayValues[i]);
      }

      for (int i = 0; i < arrayInt.Length; i++)
      {
        Console.WriteLine(arrayInt[i]);
      }

      // Second Method
      string inputLine = Console.ReadLine();
      string[] items = inputLine.Split();
      // LINQ
      int[] array = items.Select(int.Parse).ToArray();

      // Even Shorter
      array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

      // Problem: Print Numbers in Reverse Order
      // Read an array of integers (n lines of integers),
      // reverse it and print its elements on a single line, space-separated

      // Read an integer number n
      Console.WriteLine("Enter an integer number:");
      int n = int.Parse(Console.ReadLine());

      // Read values to array
      Console.WriteLine("Enter values:");
      int[] arr = new int[n];
      for (int i = 0; i < arr.Length; i++)
      {
        arr[i] = int.Parse(Console.ReadLine());
      }

      // Print the array in reverse order
      Console.WriteLine("Print the array in reverse order:");
      for (int i = arr.Length - 1; i >= 0; i--)
      {
        Console.WriteLine(arr[i]);
      }

      // for loop
      // Read and Write
      for (int i = 0; i < arr.Length; i++)
      {
        // Read
        Console.WriteLine(arr[i]);
        // Write
        arr[i] = 10;
      }

      // Read-Only
      foreach (int item in arr)
      {
        // Read
        Console.WriteLine(item);
        // item = 10; Cannot write new value 
        // C: Create
        // R: Read
        // U: Update
        // D: Delete
      }
    }
  }
}
