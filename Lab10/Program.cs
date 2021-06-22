using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab10
{
    class Program
    {
        static void Main()
        {
            List<Movie> movies = new List<Movie>() {}; 
            var movie1 = new Movie("Hitchikers guide to the galexy", "scifi");
            var movie2 = new Movie("Star Wars", "scifi");
            var movie3 = new Movie("Lost in Space", "scifi");
            var movie4 = new Movie("The Conjuring", "horror");
            var movie5 = new Movie("The Conjuring 2", "horror");
            var movie6 = new Movie("Shrek", "animated");
            var movie7 = new Movie("The Nightmare Before Christmas", "animated");
            var movie8 = new Movie("The Lion King", "animated");
            var movie9 = new Movie("Nomadland", "drama");
            var movie10 = new Movie("The Godfather", "drama");
            movies.Add(movie1);
            movies.Add(movie2);
            movies.Add(movie3);
            movies.Add(movie4);
            movies.Add(movie5);
            movies.Add(movie6);
            movies.Add(movie7);
            movies.Add(movie8);
            movies.Add(movie9);
            movies.Add(movie10);
            try
            {
                Console.WriteLine("catagory? animated/horror/scifi/drama");
                var answered = Console.ReadLine();
                var answer = movies.Where(m => m.Catagory == answered).ToList();
                answer.ForEach(x => Console.WriteLine(x.Title));
                var empty = answer[0];
            }
            catch(Exception e)
            {
                Console.WriteLine("invalid entry, try again");
                Main();
            }
            Console.WriteLine("again? y/n");
            var again = Console.ReadLine();
            if(again == "y")
            {
                Main();
            } else
            {
                Console.WriteLine("bye bye");
            }   
            
        }
    }
}
