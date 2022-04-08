using System;

namespace ClassesAndObjects
{
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

      alice.Talk(john);
      alice.Talk(spiderMan);
      spiderMan.Talk(john);

      Telephone phone = new Telephone("ABC@1234", "Apple", "iphone 7");
      spiderMan.Call(phone, "090111222");
    }

  }
}
