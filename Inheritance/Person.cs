using System;

namespace Inheritance
{
  // Define class Person
  class Person
  {
    // Properties
    public string FullName { get; set; }
    public byte Age { get; set; }
    public string Address { get; set; }
    private double _salary;
    protected double _cash;

    // Constructor
    // Without Parameter
    public Person()
    {
      FullName = "Default Name";
      Age = 0;
      Address = "Default Address";
      _salary = -1;
      _cash = 100;
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


    public void Sleep()
    {
      Console.WriteLine($"{FullName} is sleeping");
    }

    public void Talk(Person person)
    {
      Console.WriteLine($"Hello, my name is: {FullName}");
      Console.WriteLine("What is your name ???");
      Console.WriteLine($"My name is: {person.FullName}. " +
        $"Nice to meet you !!!");
    }

    public double GetSalary()
    {
      return _salary;
    }

    public void SetSalary(int newSalary)
    {
      _salary = newSalary;
    }

    public void IncreaseSalary(int addedSalary)
    {
      _salary = _salary + addedSalary;
    }

    private void BuyCar()
    {
      Console.WriteLine("Buying new car ...");
    }

    private void BuyPhone()
    {
      Console.WriteLine("Buying iPhone 13 Max Pro ...");
    }
    public void BuyStuffs()
    {
      BuyCar();
      BuyPhone();
    }

    protected void PrintCash()
    {
      Console.WriteLine(_cash);
    }

    // Overloading Methods
    public virtual void Eat()
    {
      Console.WriteLine("Eating ...");
    }
    public virtual void Eat(string food)
    {
      Console.WriteLine($"{FullName} is eating {food} ...");
    }

    public void Eat(string food, int quantity)
    {
      Console.WriteLine($"{FullName} is eating {food}. The quatity is: {quantity}");
    }

    public string Eat(int times)
    {
      return $"{FullName} is eating {times} times";
    }
  }
}
