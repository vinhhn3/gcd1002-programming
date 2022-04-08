using System;

namespace ClassesAndObjects
{
  // Define class Person
  class Person
  {
    // Properties
    public string FullName { get; set; }
    public byte Age { get; set; }
    public string Address { get; set; }
  }

  internal class Program
  {
    static void Main(string[] args)
    {
      // Declare objects Person
      // keyword: new
      Person alice = new Person();
      // 
      // Assigned values to properties of object
      // ".": access property of an object
      // VariableName.PropertyName
      alice.FullName = "ALice Kim";
      alice.Age = 35;
      alice.Address = "127B Agent Street";

      Person john = new Person();
      john.FullName = "John Wick";
      john.Age = 45;
      john.Address = "Hotel California";

      // Print info
      Console.WriteLine($"Full Name: {alice.FullName}");
      Console.WriteLine($"Age: {alice.Age}");
      Console.WriteLine($"Address: {alice.Address}");

    }
  }
}
