using System;

namespace BasicIntroduction
{
  internal class Program
  {
    static void SolveFirstDegreeFunction(double a, double b)
    {
      if (a != 0)
      {
        Console.WriteLine($"Solution of x: {-b / a}");
      }
      else if (b != 0)
      {
        Console.WriteLine("No Solution of x");
      }
      else
      {
        Console.WriteLine("Indefinite solution number of x");
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      SolveFirstDegreeFunction(1, 2);
      SolveFirstDegreeFunction(0, 2);
      SolveFirstDegreeFunction(1, 0);

    }
  }


}
