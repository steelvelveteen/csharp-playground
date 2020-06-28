using System;

namespace csharp_playground
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        /* Below we extend the parent's GetInfo by adding some extra functionality using the override keyword. Suppose a scenario where you can't access the parent's base class as it would be the case for thrid-party libraries you would have to use the new keyword instead, which will ignore the parent's version.*/
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a Radius of {Radius}");
        }
    }
}