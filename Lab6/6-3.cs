using System;
using System.Collections.Generic;

class Movie : ICloneable, IComparable<Movie>
{
    public string Title { get; set; }
    public double Rating { get; set; }

    public object Clone()
    {
        return new Movie { Title = this.Title, Rating = this.Rating };
    }

    public int CompareTo(Movie other)
    {
        return this.Rating.CompareTo(other.Rating);
    }

    public override string ToString()
    {
        return $"{Title} - Rating: {Rating}";
    }
}

class Program
{
    static void Main()
    {
        List<Movie> movies = new List<Movie>
        {
            new Movie { Title = "Inception", Rating = 8.8 },
            new Movie { Title = "Interstellar", Rating = 8.6 },
            new Movie { Title = "Tenet", Rating = 7.5 }
        };

        movies.Sort();

        Console.WriteLine("Відсортований список фільмів за рейтингом:");
        foreach (var movie in movies)
        {
            Console.WriteLine(movie);
        }

        Movie original = movies[0];
        Movie copy = (Movie)original.Clone();

        Console.WriteLine("\nКопія фільму:");
        Console.WriteLine(copy);
    }
}
