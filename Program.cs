using System;
using System.Threading.Tasks;

namespace csharp_playground
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var database = new Database();

            var persons = await database.QueryAsync<Person>("SELECT first_name as FirstName, last_name as LastName, country_of_birth as CountryOfBirth FROM person FETCH first 10 ROW only");
            Console.WriteLine(persons);
            foreach (var person in persons)
            {
                Console.WriteLine($"Person Id, Email and ...: {person.FirstName} {person.LastName} - {person.CountryOfBirth}");
            }
        }
    }
}
