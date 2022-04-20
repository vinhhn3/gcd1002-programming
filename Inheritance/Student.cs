using System;

namespace Inheritance
{
  // Student inherits Person
  class Student : Person
  {
    public string School { get; set; }
    public string Major { get; set; }


    // base keyword
    // Call function of the Parent class
    public Student() : base()
    {
      //FullName = "Default Name";
      //Age = 0;
      //Address = "Default Address";
      School = "Default School";
      Major = "Default Major";
    }

    public Student(string fullName, byte age,
      string address, string school, string major)
      : base(fullName, age, address)
    {
      School = school;
      Major = major;
    }

    public void Eat()
    {
      //Console.WriteLine("Eating ...");
      base.Eat();     // Method Eat() of Person class
      Console.WriteLine("Student eats a lot ...");
      base.Sleep();
    }

    public void PrintInfo()
    {
      Console.WriteLine(GetSalary()); // public
      Console.WriteLine(_cash);
      PrintCash();                          // protected
    }
  }
}
