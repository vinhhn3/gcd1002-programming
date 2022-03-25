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

    }
  }
}
