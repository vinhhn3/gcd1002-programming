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

    public void Talk(Person person)
    {
      Console.WriteLine($"Hello, my name is: {FullName}");
      Console.WriteLine("What is your name ???");
      Console.WriteLine($"My name is: {person.FullName}. " +
        $"Nice to meet you !!!");
    }

    public void Call(Telephone telephone, string telephoneNumber)
    {
      Console.WriteLine($"{FullName} is making a call ...");
      telephone.MakeCall(telephoneNumber);
    }

  }
}
