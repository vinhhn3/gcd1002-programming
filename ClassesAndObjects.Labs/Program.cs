using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ClassesAndObjects.Labs
{
  internal class Program
  {
    static void Main(string[] args)
    {
      // Songs
      int numberOfSongs = int.Parse(Console.ReadLine());
      List<Song> songs = new List<Song>();
      for (int i = 0; i < numberOfSongs; i++)
      {
        Console.WriteLine("Enter the song with following format:" +
          "{typeList}_{name}_{time}");
        string inputSong = Console.ReadLine();
        List<string> listProperties = inputSong
                                        .Split("_")
                                        .ToList();
        Song tempSong = new Song(
          listProperties[0],
          listProperties[1],
          listProperties[2]);
        songs.Add(tempSong);
      }

      Console.WriteLine("Enter type list name:");
      string typeListInput = Console.ReadLine();
      foreach (var song in songs)
      {
        if (song.TypeList.Equals(typeListInput))
        {
          Console.WriteLine(song.Name);
        }
      }

      Console.WriteLine("Hello World!");
      // Day of Week
      // You are given a date in format day-month-year.
      // Calculate and print the day of week in English.
      Console.WriteLine("Enter a date: dd/MM/yyyy");
      string inputDate = Console.ReadLine();
      string format = "dd/MM/yyyy";
      CultureInfo provider = new CultureInfo("fr-FR");
      DateTime date = DateTime.ParseExact(inputDate, format, provider);
      Console.WriteLine(date.DayOfWeek);

      //Randomize Words
      //You are given a list of words in one line.
      //Randomize their order and print each word at a separate line.
      string inputLine = Console.ReadLine();
      List<string> listString = inputLine
                                    .Split()
                                    .ToList();
      Random rnd = new Random();
      while (listString.Count != 0)
      {
        int temp = rnd.Next(0, listString.Count - 1);
        Console.WriteLine(listString[temp]);
        listString.RemoveAt(temp);
      }


    }
  }
}
