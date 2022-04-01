using System;

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

      // Enter a day number [1…7] and
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



    }
  }
}
