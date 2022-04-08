namespace ClassesAndObjects.Labs
{
  //  Songs
  //Define a class Song, which holds the following information about songs:
  //Type List, Name and Time.

  internal class Song
  {
    public string TypeList;
    public string Name;
    public string Time;

    public Song(string typeList, string name, string time)
    {
      TypeList = typeList;
      Name = name;
      Time = time;
    }

    public Song(string name, string time)
    {
      Name = name;
      Time = time;
    }
  }
}
