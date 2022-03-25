using System;

namespace BasicSyntax
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Declare Variable
      // DataType variableName = value;
      // Variable must be meaningful
      int myAge = 10;
      double mySalaryAtGreenwich = 10.0;
      float myHeight = 123;
      string fullName = "Hoang Nhu Vinh";
      char myFavorite = 'c';

      // Print to screen
      Console.WriteLine(myAge);
      Console.WriteLine("My Salary: " + mySalaryAtGreenwich);
      Console.WriteLine($"My Full Name is: {fullName}"); // My Full Name is Hoang Nhu Vinh
      Console.WriteLine($"My height: {myHeight} and my favorite is: {myFavorite}");
      Console.WriteLine("My height is: {0} and my favorite is: {1}",
          myHeight, myFavorite
        );

      // Receive Input
      Console.WriteLine("Enter your address: ");
      string address = Console.ReadLine(); // return string
      Console.WriteLine($"Address is: {address}");

      // Convert string to int
      Console.WriteLine("Enter your new age: ");
      myAge = int.Parse(Console.ReadLine());
      Console.WriteLine($"Your new age: {myAge}");

      // Comparaison Operators
      int a = 5;
      int b = 10;
      Console.WriteLine(a < b);       // true			
      Console.WriteLine(a > 0);       // true
      Console.WriteLine(a > 100);     // false
      Console.WriteLine(a < a);       // false
      Console.WriteLine(a <= 5);      // true
      Console.WriteLine(b == 2 * a);  // true

      // Logical Operators
      // AND (&&)
      // true && true = true
      Console.WriteLine((a > 1) && (b > a));  // true

      // OR (||)
      // false || false = false
      Console.WriteLine(a > 6 || b > 12);    // false
      Console.WriteLine(a > 6 || b > 3);    // true

      // NOT (!)
      Console.WriteLine(!(a > 6));    // !false = true

      // if-else statements
      // if (condition 1)
      // {
      //    doSomething();
      // }
      // else if (condition 2)
      // {
      //    doAnotherThing();
      // }
      // else
      // {
      //    doThis();
      // }
      myAge = 20;
      if (myAge > 18 && myAge < 60)
      {
        Console.WriteLine("You can buy cigaretters");
      }
      else if (myAge > 60)
      {
        Console.WriteLine("Do not smoke, you will die soon");
      }
      else
      {
        Console.WriteLine("You cannot buy cigarettes");
      }

      // switch case statements
      string myGrade = "Pass";
      switch (myGrade)
      {
        case "Pass":
          Console.WriteLine("Your mark is between 5 and 6.5");
          break;
        case "Merit":
          Console.WriteLine("Your mark is between 7 and 8.5");
          break;
        case "Distinction":
          Console.WriteLine("Your mark is between 9 and 10");
          break;
        default:
          Console.WriteLine("Failed ... Your mark is less than 5");
          break;
      }
    }
  }
}
