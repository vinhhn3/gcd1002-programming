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
    }
  }
}
