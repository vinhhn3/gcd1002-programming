using System;

namespace Methods.Lab
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      PrintTriangle(4);
      Console.WriteLine(GetMultipleOfEvensAndOdds(-12345));
    }

    // Printing Triangle Problem
    static void PrintTriangle(int size)
    {
      PrintFirstHalfTriangle(size);
      PrintSecondHalfTriangle(size);
    }

    static void PrintFirstHalfTriangle(int size)
    {
      for (int i = 1; i <= size; i++)
      {
        for (int y = 1; y <= i; y++)
        {
          Console.Write(y);
          Console.Write(" ");
        }
        Console.WriteLine();
      }
    }

    static void PrintSecondHalfTriangle(int size)
    {
      for (int i = size - 1; i >= 1; i--)
      {
        for (int y = 1; y <= i; y++)
        {
          Console.Write(y);
          Console.Write(" ");
        }
        Console.WriteLine();
      }
    }

    // Problem: Multiply Evens by Odds
    static int GetMultipleOfEvensAndOdds(int number)
    {
      return GetSumOfEvenDigits(Math.Abs(number)) * GetSumOfOddDigits(Math.Abs(number));
    }

    static int GetSumOfEvenDigits(int number)
    {
      int sum = 0;
      while (number != 0)
      {
        int moduloByTen = number % 10;
        if (IsEven(moduloByTen))
        {
          sum = sum + moduloByTen;
        }
        number = number / 10;
      }

      return sum;
    }

    static int GetSumOfOddDigits(int number)
    {
      int sum = 0;
      while (number != 0)
      {
        int moduloByTen = number % 10;
        if (!IsEven(moduloByTen))
        {
          sum = sum + moduloByTen;
        }
        number = number / 10;
      }
      return sum;
    }

    static bool IsEven(int number)
    {
      return number % 2 == 0;
    }

  }
}
