using System;
using System.Collections.Generic;
using System.IO;

namespace Files
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      List<Movies> movies = new List<Movies>();
      StreamReader sr = new StreamReader("C:\\Users\\barbora.slavikova\\Desktop\\cSharpSPSMB\\src\\4rocnik\\Maturita\\Files\\movies.csv");

      string line;
      string[] item =  new string[8];
      while ((line = sr.ReadLine()) != null)
      { 
        item = line.Split(',');
        
        movies.Add(new Movies
        {
          Film = item[0],
          Genre = item[1],
          LeadStudio = item[2],
          AudienceScore = int.Parse(item[3]),
          Profitability = double.Parse(item[4]),
          RottenTomatoes = int.Parse(item[5]),
          WorldwideGross = double.Parse(item[6]),
          Year = int.Parse(item[7])
        });
      }
    }
  }
}