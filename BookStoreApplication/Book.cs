namespace BookStoreApplication
{
  class Book
  {
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    private Book()
    {

    }
    public Book(int id, string name, string author, double price)
    {
      Id = id;
      Name = name;
      Author = author;
      Price = price;
    }
  }
}
