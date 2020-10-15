using System;
using System.Linq;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            QueryStringArray();
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
            Console.WriteLine();

            Console.WriteLine($"Get type: {gt20.GetType()}");
            var listGT20 = gt20.ToList<int>();
            var arrayGT20 = gt20.ToArray();

            return arrayGT20;
        }
    }
}
