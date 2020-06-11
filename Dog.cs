using System;

namespace csharp_playground
{
    public class Dog : Animal
    {
        public string Sound2 { get; set; } = "Default Grrr";

        public new void MakeSound()
        {
            Console.WriteLine($"{Name} says {Sound} and {Sound2}");
        }

        public Dog(string name = "No Dog name", string sound = "No Dog sound", string sound2 = "No dog sound2") : base(name, sound)
        {
            Sound2 = sound2;
        }
    }
}