using System;
using System.Collections.Generic;
using System.Linq;

namespace FavoriteMovies
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> movies = new List<string>();

            // Prompt user to enter movies until they want to stop
            do
            {
                Console.Write("Enter a movie name (or 'quit' to finish): ");
                string movie = Console.ReadLine().Trim();

                if (movie.ToLower() == "quit")
                    break;

                movies.Add(movie);

            } while (true);

            // Sort the list of movies alphabetically
            movies.Sort();

            // Prompt user for search repeatedly until they want to stop
            do
            {
                Console.WriteLine("\nChoose an option:");
                Console.WriteLine("1. Partial Search");
                Console.WriteLine("2. Exact Search");
                Console.WriteLine("3. Quit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine().Trim();

                switch (choice)
                {
                    case "1":
                        Console.Write("\nEnter a word or phrase to search (Partial Search): ");
                        string searchTerm = Console.ReadLine().Trim().ToLower();
                        List<string> partialMatches = movies
                            .Where(m => m.ToLower().Contains(searchTerm))
                            .ToList();

                        Console.WriteLine("\nPartial Search Results:");
                        if (partialMatches.Count > 0)
                        {
                            foreach (var match in partialMatches)
                            {
                                Console.WriteLine(match);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No matches found.");
                        }
                        break;

                    case "2":
                        Console.Write("\nEnter a movie name to search (Exact Search): ");
                        string exactSearchTerm = Console.ReadLine().Trim().ToLower();
                        bool exactMatch = movies
                            .Any(m => m.ToLower() == exactSearchTerm);

                        if (exactMatch)
                        {
                            Console.WriteLine("\nExact Search Result: Movie found.");
                        }
                        else
                        {
                            Console.WriteLine("\nExact Search Result: Movie not found.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nGoodbye!");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice. Please enter 1, 2, or 3.");
                        break;
                }

            } while (true);
        }
    }
}
