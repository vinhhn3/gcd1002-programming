using System;

namespace Methods
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int fixedSalary = 100;
      int bonus = 20;
      int totalSalary = SumTwoInt(fixedSalary, bonus); // 120

      int humanCost = 120;
      int materialCost = 140;
      int totalCost = SumTwoInt(humanCost, materialCost);
    }

    // Define a method/function:
    // DataTypeReturn MethodName(dataType arg1, dataType arg2){
    //  doSomething();
    // }
    static int SumTwoInt(int a, int b)
    {
      int result = a + b;
      return result;
    }

    static int SumThreeInt(int a, int b, int c)
    {
      int result = SumTwoInt(a, SumTwoInt(b, c));
      return result;
    }
  }
}
