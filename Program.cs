using System;
using System.Linq;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
            QueryIntArray();
            Console.ReadLine();
        }

        static void QueryStringArray()
        {
            string[] dogs = { "K 9", "Brian Griffin", "Scooby Doo", "Old Yeller", "Rin Tin Tin", "Benji", "Charlie B. Barkin", "Lassie", "Snoopy" };

            var dogSpaces = from dog in dogs
                            where dog.Contains(" ")
                            orderby dog descending
                            select dog;

            foreach (var i in dogSpaces)
            {
                Console.WriteLine(i);
            }

            ReflectOverQueryResults(dogSpaces, "Explicit");
            Console.WriteLine("Press any key to continue ....");
            Console.ReadLine();
        }

        static int[] QueryIntArray()
        {
            int[] nums = { 5, 10, 15, 20, 25, 30, 35 };

            var gt20 = from num in nums
                       where num > 20
                       orderby num
                       select num;

            foreach (var i in gt20)
            {
                Console.WriteLine(i);
            }

            ReflectOverQueryResults(gt20);

            Console.WriteLine();

            Console.WriteLine($"Get type: {gt20.GetType()}");
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            return arrayGT20;
        }

        static void ReflectOverQueryResults(object subset, string queryType = "Explicit")
        {
            Console.WriteLine($"**** Info on the query using {queryType} ****");
            Console.WriteLine("Result set is of type {0}", subset.GetType().Name);
        }
    }
}
