using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // Circle firstCircle = new Circle(25);
            // firstCircle.GetInfo();
            // firstCircle.Area();

            // Rectangle firstRect = new Rectangle(10, 22);
            // firstRect.GetInfo();
            // firstRect.Area();

            Shape[] shapes = {
                new Circle(5),
                new Rectangle(4, 5)
            };

            foreach (Shape s in shapes)
            {
                s.GetInfo();

                Console.WriteLine("{0} Area: {1:f2}", s.Name, s.Area());

                Circle testCircle = s as Circle;
                if (testCircle == null)
                {
                    Console.WriteLine($"{s.Name} is not a circle.");
                }

                /* The is operator is used to check if the run-time type of an object is compatible with the given type or not whereas as operator is used to perform conversion between compatible reference types or Nullable types. The is operator is of boolean type, the as operator is not.*/
                if (testCircle is Circle)
                {
                    Console.WriteLine($"{s.Name} is in fact a circle.");
                }
            }
        }
    }
}
