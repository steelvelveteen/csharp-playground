using System;

namespace csharp_playground
{
    public class SporsterCar : IDrivable, IConvertible
    {
        public bool IsHoodOpen { get; set; }
        public string Brand { get; set; }
        public int Wheels { get; set; }
        public double Speed { get; set; } 

        public SporsterCar(string brand = "Lambo", int wheels = 4, double speed = 55, bool isHoodOpen = false)
        {
            Brand = brand;
            Wheels = wheels;
            Speed = speed;
            IsHoodOpen = isHoodOpen;
        }
        public void Accelerate()
        {
            Speed = Speed * 2.5;
            Console.WriteLine($"Sporster {Brand} accelerated to {Speed} miles per hour");
        }

        public void Move()
        {
            Console.WriteLine($"Sporster {Brand} currently at {Speed}");
        }

        public void OpenHood()
        {
            IsHoodOpen = true;
            Console.WriteLine($"Sporster {Brand} is now open air");
        }

        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}