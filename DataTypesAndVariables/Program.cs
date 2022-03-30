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
      //float weightInFloat = weight;  Cannot convert because 32 bits (float) < 64 bits (double)

      // Explicit Conversion
      float weightInFloat = (float)weight;

      double age = 18.15;       // 64 bits
      int ageInt = (int)age;    // 32 bits

      Console.WriteLine(ageInt);  // 18
    }
  }
}
