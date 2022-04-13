namespace Inheritance
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Student student = new Student();
      student.Sleep();
      student.Eat();

      Person person = new Person("Holmes", 45, "127B");
      student.Talk(person);
    }
  }
}
