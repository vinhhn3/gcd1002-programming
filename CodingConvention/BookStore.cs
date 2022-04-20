using System;
using System.Collections.Generic;
using System.Linq;

namespace CodingConvention
{
  // Name of class: PascalCase
  // Everthing must be in English. no Vietnamese
  // Everthing must be meaningful
  class BookStore
  {
    // Public Properties name: PascalCase
    public string Name { get; set; }
    public string Address { get; set; }
    // List: plural
    public List<Book> Books { get; set; }
    // Private and Protected properties: _camelCase
    private double _amountMoney { get; set; }
    // Method name: PascalCase
    // Verb + Noun
    public void PrintDetails()
    {
      Console.WriteLine(Name + " " + Address);
    }

    // Parameter: camelCase
    public void SetMoney(double newAmount)
    {
      _amountMoney = newAmount;
    }

    public double CalculateProfit()
    {
      // Variable: camelCase
      double maintainCost = 100;
      double totalBooksPrice = Books.Sum(t => t.Price);
      double profit = totalBooksPrice - maintainCost;
      return profit;
    }

    // If return bool => Method name should begin with Is/Have/Any
    // Example: IsBroke, HaveAnyBook
    public bool IsBroke()
    {
      return _amountMoney <= 0;
    }
  }
}
