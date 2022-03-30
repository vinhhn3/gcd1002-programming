using System;

namespace DataTypesAndVariables
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Declare a variable
      // DataType variableName = value;
      int myAge = 10;

      // Overflow 
      // 1 byte = 8 bits => maxValue = 2^8 - 1 = 255
      byte counter = 250;
      for (int i = 0; i < 10; i++)
      {
        counter++;
        Console.WriteLine(counter);
        // 251
        // 252
        // 253
        // 254
        // 255
        // 0
        // 1
        // 2
        // 3
        // 4

      }
      // Float and Double Data Type
      Console.WriteLine((0.1 + 0.2) == 0.3);      // false
      Console.WriteLine((0.1 + 0.2) > 0.3);       // true
      Console.WriteLine((0.1 + 0.2) - 0.3 == 0);  // false
      float mySalary = 1.1234567F;    // 7 digits => 32 bits
      double pi = 3.141231241111231D; // 15 - 16 digits => 64 bits

      // Type Conversion
      float size = 70.12f;        // 32 bits
      // Direct Conversion
      double sizeInDouble = size; // 64 bits

      double weight = 70.12;        // 64 bits
      //float weightInFloat = weight;
      //Cannot convert because 32 bits (float) < 64 bits (double)

      // Explicit Conversion
      float weightInFloat = (float)weight;

      double age = 18.15;       // 64 bits
      int ageInt = (int)age;    // 32 bits

      Console.WriteLine(ageInt);  // 18

      // Exercise
      /*
      Write program to enter an integer number of centuries 
      and convert it to years, days, hours and minutes
      1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
      5 centuries = 500 years = 182621 days = 4382904 hours = 262974240 minutes
      */

      Console.WriteLine("Enter centuries:");
      int centuries = int.Parse(Console.ReadLine());
      int years = centuries * 100;
      int days = (int)(years * 365.2422);
      int hours = days * 24;
      int minutes = hours * 60;

      Console.WriteLine(
        $"{centuries} centuries = " +
        $"{years} years = " +
        $"{days} days = " +
        $"{hours} hours = " +
        $"{minutes} minutes");

      // Boolean Type
      // True and False
      int a = 1;
      int b = 2;
      bool greaterAB = (a > b);
      Console.WriteLine(greaterAB);  // False
      bool equalA1 = (a == 1);
      Console.WriteLine(equalA1);    // True

      // Character Type
      char ch = 'a';  // 16 bits
      Console.WriteLine(ch);        // 'a'
      Console.WriteLine((int)ch);   // 97
      Console.WriteLine((char)65);  // 'A'

      // Convert lower case character to upper case character
      Console.WriteLine("Enter a lower case character: ");
      char lowerCase = Convert.ToChar(Console.ReadLine());
      Console.WriteLine("Converting to Upper Case ...");
      char upperCase = (char)((int)lowerCase - 32);
      Console.WriteLine(upperCase);

      // Character Literals
      char symbol = 'a';
      symbol = '\n';  // New Line
      symbol = '\t';  // Tab
      symbol = '\\';  // backslah
      Console.WriteLine(symbol); // '\'
      symbol = '\u8449'; // Chinese character
      Console.WriteLine(symbol);
    }
  }
}
