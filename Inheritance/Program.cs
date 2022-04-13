using System;

namespace Inheritance
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Person person = new Person();
      Console.WriteLine(person.FullName);
      Console.WriteLine(person.GetSalary());  // -1
      person.SetSalary(100);
      Console.WriteLine(person.GetSalary());  // 100
      person.IncreaseSalary(267);
      Console.WriteLine(person.GetSalary());  // 100 + 267 = 367
      person.BuyStuffs();
      //Console.WriteLine(person._cash);

      Student student = new Student();
      Console.WriteLine(student.FullName);  // Default Name
      Console.WriteLine(student.Age);       // 0
      Console.WriteLine(student.Address);   // Default Address
      Console.WriteLine(student.School);    // Default School
      Console.WriteLine(student.Major);     // Default Major

      Student anotherStudent = new Student(
          "John Doe",
          29,
          "Hotel My Khe",
          "Elementary School No 1",
          "Computing"
        );

      Console.WriteLine(anotherStudent.FullName); // John Doe
      Console.WriteLine(anotherStudent.Major);    // Computing 
      anotherStudent.PrintInfo();

      student.Eat();



    }
  }
}
