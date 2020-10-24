using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal whiskers = new Animal()
            {
                Name = "Whiskers",
                Sound = "Meoww"
            };

            Dog grover = new Dog()
            {
                Name = "Grover",
                Sound = "Woof",
                Sound2 = "Grrrrr"
            };

            grover.Sound = "Wooooof";
            whiskers.MakeSound();
            grover.MakeSound();


            whiskers.SetAnimalIDInfo(12345, "Smith");
            grover.SetAnimalIDInfo(54321, "Sally Brown");

            whiskers.GetAnimalIDInfo();
            grover.GetAnimalIDInfo();
        }
    }
}
