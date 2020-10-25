using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Car class that has the ability to inform external entities about its current engine state.");
            Car c1 = new Car("SlugBug", 100, 10);

            c1.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineEvent));

            Console.WriteLine("**** Speeding up ****");
            for (int i = 0; i < 6; i++)
                c1.Accelerate(20);
            Console.ReadLine();
        }

        public static void OnCarEngineEvent(string msg)
        {
            Console.WriteLine("\n**** Message from Car Object ****");
            Console.WriteLine("=> {0}", msg);
            Console.WriteLine("***************************\n");
        }
    }

    public class Car
    {
        // 1) Defining a delegate type
        public delegate void CarEngineHandler(string msgForCaller);
        // 2) Defining a member variable of this delegate
        private CarEngineHandler listOfHandlers;
        // 3) Add registration function for the caller
        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }
        // 4) Implement the Accerelate() method to invoke the delegates'
        // invocation list under the right circumstances
        public void Accelerate(int delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                {
                    listOfHandlers.Invoke("Sorry, this car is dead ...");
                }
            }
            else
            {
                CurrentSpeed += delta;

                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Careful buddy! Gonna blow!");
                }
                if (CurrentSpeed >= MaxSpeed)
                {
                    carIsDead = true;
                }
                else
                {
                    Console.WriteLine("CurrentSpeed = {0}", CurrentSpeed);
                }
            }
        }
        // Internal state data.
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        public Car() { }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }
    }
}
