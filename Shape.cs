using System;

namespace csharp_playground
{
    public abstract class Shape
    {
        public string Name { get; set; } = "Default shape name";

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is a {Name}");
        }

        public abstract double Area();
    }
}