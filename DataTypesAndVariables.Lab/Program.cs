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

      // A number is special when its sum of digits is 5, 7 or 11.
      // Write a program to read an integer n and for all numbers in the range 1…n
      // to print the number and if it is special or not (True / False).
      Console.WriteLine("Enter a number: ");
      int number = int.Parse(Console.ReadLine());
      for (int i = 1; i <= number; i++)
      {
        int temp = i;
        int modulo;
        int sumOfDigits = 0;
        while (temp > 0)
        {
          modulo = temp % 10;
          sumOfDigits = sumOfDigits + modulo;
          temp = temp / 10;
        }
        if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
        {
          Console.WriteLine($"{i} => True");
        }
        else
        {
          Console.WriteLine($"{i} => False");
        }
      }

      // Write a program to read an integer n and
      // print all triples of the first n small Latin letters, ordered alphabetically:
      Console.WriteLine("Enter an integer n: ");
      int n = int.Parse(Console.ReadLine());
      for (int i1 = 0; i1 < n; i1++)
      {
        for (int i2 = 0; i2 < n; i2++)
        {
          for (int i3 = 0; i3 < n; i3++)
          {
            char letter1 = (char)('a' + i1);
            char letter2 = (char)('a' + i2);
            char letter3 = (char)('a' + i3);
            Console.WriteLine($"{letter1}{letter2}{letter3}");
          }
        }
      }

      // Read two names and a delimiter. Print the names joined by the delimiter
      Console.WriteLine("Enter first name: ");
      string firstName = Console.ReadLine();
      Console.WriteLine("Enter last name: ");
      string lastName = Console.ReadLine();
      Console.WriteLine("Enter delimiter: ");
      string delimiter = Console.ReadLine();
      Console.WriteLine(firstName + delimiter + lastName);

    }
  }
}
