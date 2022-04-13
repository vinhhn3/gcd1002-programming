using System;

namespace Inheritance
{
  internal class Program
  {
    static void Main(string[] args)
    {
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

      student.Sleep();
      student.Eat();

    }
  }
}
