using System;
using System.Collections.Generic;
using System.Linq;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Usage of linq queries using extensions");
            QueryOverStringWithExtensionMethods();
            Console.ReadLine();
        }

        static void QueryOverStringWithExtensionMethods()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            IEnumerable<string> subset = currentVideoGames.Where(g => g.Contains(" ")).OrderBy(g => g).Select(g => g);

            foreach (string s in subset)
            {
                Console.WriteLine("Video game: {0}", s);
            }

        }
    }
}
