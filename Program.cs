using System;
using System.Collections.Generic;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> superheroes = GetSuperHeroes();

            Console.WriteLine($"Number of superheroes: {superheroes.Count}");

            // Retrieve one
            superheroes.TryGetValue("Tony Stark", out string selection);
            Console.WriteLine($"Selected superheroe: {selection}");

            // Traversing through dictionary list
            foreach (KeyValuePair<string, string> heroe in superheroes)
            {
                Console.WriteLine($"Hereo {heroe.Value} hides under {heroe.Key}");
            }
        }

        public static IDictionary<string, string> GetSuperHeroes()
        {
            return new Dictionary<string, string> {
                { "Clark Kent", "Superman" },
                { "Bruce Wayne", "Batman" },
                { "Tony Stark v", "Iron Man" }
            };
        }
    }
}
