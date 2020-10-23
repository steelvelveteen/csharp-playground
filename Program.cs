using System;
using System.Collections.Generic;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, string> superheroes = new Dictionary<string, string>();

            superheroes.Add("Clark Kent", "Superman");
            superheroes.Add("Bruce Wayne", "Batman");
            superheroes.Add("Tony Stark", "Iron Man");

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
    }
}
