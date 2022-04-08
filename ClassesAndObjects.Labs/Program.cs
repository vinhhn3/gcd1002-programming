using System;
using System.Globalization;

namespace ClassesAndObjects.Labs
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // Day of Week
      // You are given a date in format day-month-year.
      // Calculate and print the day of week in English.
      Console.WriteLine("Enter a date: dd/MM/yyyy");
      string inputDate = Console.ReadLine();
      string format = "dd/MM/yyyy";
      CultureInfo provider = new CultureInfo("fr-FR");
      DateTime date = DateTime.ParseExact(inputDate, format, provider);
      Console.WriteLine(date.DayOfWeek);


    }
  }
}
