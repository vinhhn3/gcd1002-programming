namespace Inheritance
{
  // Student inherits Person
  class Student : Person
  {
    public string School { get; set; }
    public string Major { get; set; }


    // base keyword
    // Call function of the Parent clas
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
  }
}
