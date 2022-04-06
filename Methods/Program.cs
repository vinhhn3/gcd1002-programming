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

      int age = 10;               // Stack
      IncreaseAge(age);         // Heap

      Console.WriteLine(age); // 10 Stack
      int[] arrayAge = new int[]
      {
        10
      };

      Console.WriteLine(arrayAge[0]);   // 10 Heap
      IncreaseAgeArray(arrayAge);        // Heap
      Console.WriteLine(arrayAge[0]);   // 11 

    }

    static void IncreaseAgeArray(int[] arr)
    {
      arr[0] = arr[0] + 1;
    }

    static void IncreaseAge(int a)
    {
      a = a + 1;
      Console.WriteLine(a); // 11 Heap
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
