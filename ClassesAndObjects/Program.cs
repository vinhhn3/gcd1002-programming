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

    // Constructor
    // Without Parameter
    public Person()
    {
      FullName = "Default Name";
      Age = 0;
      Address = "Default Address";
    }

    // With Params
    public Person(string fullName, byte age, string address)
    {
      FullName = fullName;
      Age = age;
      Address = address;
    }

    public Person(string fullName, byte age)
    {
      FullName = fullName;
      Age = age;
      Address = "Homeless";
    }

    public Person(string firstName, string lastName, byte age)
    {
      FullName = firstName + " " + lastName;
      Age = age;
      Address = "No Way Home";
    }

    // Methods
    public void Eat()
    {
      Console.WriteLine("Eating ...");
    }

    public void Eat(string food)
    {
      Console.WriteLine($"{FullName} is eating {food}");
    }

  }

  internal class Program
  {
    static void Main(string[] args)
    {
      Person defaultPerson = new Person();
      Person anotherPerson = new Person();

      // Declare objects Person
      // keyword: new
      Person alice = new Person(
        "Alice Kim", 35, "127B Agent Street");
      // 
      // Assigned values to properties of object
      // ".": access property of an object
      // VariableName.PropertyName
      //alice.FullName = "Alice Kim";
      //alice.Age = 35;
      //alice.Address = "127B Agent Street";

      Person john = new Person(
        "John Wick", 45, "Hotel California"
        );
      //john.FullName = "John Wick";
      //john.Age = 45;
      //john.Address = "Hotel California";

      Person spiderMan = new Person(
        "Peter", "Parker", 23);

      // Print info
      Console.WriteLine($"Full Name: {alice.FullName}");
      Console.WriteLine($"Age: {alice.Age}");
      Console.WriteLine($"Address: {alice.Address}");

      spiderMan.Eat();
      spiderMan.Eat("Pizza");
    }
  }
}
