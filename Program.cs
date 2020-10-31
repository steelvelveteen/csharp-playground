using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.Length = 10;
            rec.Height = 20;
            Console.WriteLine($"Area of rec: {rec.Area()}");
        }
    }
    // Not much to learn except for one key thing:
    // structs are value types and so they are stored
    // in the stack as opposed to classes which are ref
    // values and stored in the heap
    public struct Rectangle
    {
        public double Length { get; set; }
        public double Height { get; set; }

        public readonly double Area()
        {
            return Length * Height;
        }
    }
}
