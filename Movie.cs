using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Movie
{   
    public Movie(string movieName, double movieRating, string director, int year)
    {
        MovieName = movieName;
        MovieRating = movieRating;
        Director = director;
        Year = year;
    }
    
    public string MovieName { get; set; }
    public double MovieRating { get; set; }
    public string Director { get; set; }
    public int Year { get; set; }
}