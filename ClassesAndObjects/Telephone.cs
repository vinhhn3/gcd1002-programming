using System;

namespace ClassesAndObjects
{
  class Telephone
  {
    public string SerieNumber { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }

    public Telephone()
    {
    }

    public Telephone(string serieNumber, string brand, string model)
    {
      SerieNumber = serieNumber;
      Brand = brand;
      Model = model;
    }

    public void MakeCall(string phoneNumber)
    {
      Console.WriteLine(
        $"{SerieNumber} - {Model} is calling to {phoneNumber}");
    }
  }
}
