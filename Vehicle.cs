using System;

namespace csharp_playground
{
    public class Vehicle : IDrivable
    {
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public Vehicle(string brand = "No brand", int wheels = 0, double speed = 0)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
        }

        public void Move()
        {
            Console.WriteLine($"My {Brand} moves now at {Speed}");
        }

        public void Accelerate()
        {
            Speed = Speed * 2;
            Console.WriteLine($"My {Brand} moves now at {Speed}");
        }
        public void Stop()
        {
            Speed = 0;
            Console.WriteLine($"My {Brand} has now stopped: {Speed}");
        }
    }
}