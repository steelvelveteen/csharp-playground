using System.Reflection.Emit;
using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myFirstVehicle = new Vehicle("Opel Corsa City", speed: 40);
            Console.WriteLine($"The first car I ever had was a {myFirstVehicle.Brand}");
            SporsterCar sportsCar = new SporsterCar("Tesla Sporster", speed: 60, isHoodOpen: false);

            

            myFirstVehicle.Move();
            myFirstVehicle.Accelerate();
            myFirstVehicle.Stop();
            if (myFirstVehicle is IConvertible)
            {

            } else {
                Console.WriteLine($"{myFirstVehicle.Brand} is not convertible!!");
            }

            sportsCar.Move();
            sportsCar.Accelerate();

            if (sportsCar is IConvertible)
            {
                sportsCar.OpenHood();
            }
        }
    }
}
