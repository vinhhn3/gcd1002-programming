using System;

namespace DataTypesAndVariables.Lab
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Read four integer numbers.
      //Add first to the second,
      //divide(integer) the sum by the third number
      //and multiply the result by the fourth number.
      //Print the result.

      Console.WriteLine("Read four integer numbers: ");
      int firstNumber = int.Parse(Console.ReadLine());
      int secondNumber = int.Parse(Console.ReadLine());
      int thirdNumber = int.Parse(Console.ReadLine());
      int fourthNumber = int.Parse(Console.ReadLine());

      int result = ((firstNumber + secondNumber) / thirdNumber) * fourthNumber;
      Console.WriteLine(result);

      //Write program to enter a radius r (real number) and
      //prints the area of the circle with exactly 12 digits after the decimal point:

      Console.WriteLine("Enter radius r: ");
      double r = double.Parse(Console.ReadLine());
      double circleArea = Math.PI * r * r;
      Console.WriteLine("{0:F12}", circleArea);

      // Calculate how many courses will be needed to elevate n persons
      // by using an elevator of capacity of p persons.
      // The input holds two lines: the number of people n and the capacity p of the elevator.
      Console.WriteLine("Enter number of people");
      int numberOfPeople = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the capacity of elevator: ");
      int elevatorCapacity = int.Parse(Console.ReadLine());

      int courses = (int)Math.Ceiling((double)numberOfPeople / elevatorCapacity);
      // n = 10
      // c = 4
      // courses = 10 / 4 = round(2.5) => 3
      Console.WriteLine($"Courses needed: {courses}");
    }
  }
}
