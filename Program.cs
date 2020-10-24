using System;

namespace csharp_playground
{
    class Program
    {
        // Declare a delegate with the same signature as the method SayHelloo
        // you want to store to be invoked later => void and no parameters
        public delegate void SayHelloDelegate();
        public delegate void SayHiWithNameDelegate(string name);

        
        static void Main(string[] args)
        {
          // Create new instance of delegate and pass in the static method
          // Syntactic sugar : SayHelloDelegate sayHiDelegate = SayHello;
          SayHelloDelegate sayHiDelegate = new SayHelloDelegate(SayHello);  
          SayHiWithNameDelegate sayHiNameDelegate = SayHelloWithName;

          // Invoke the method via the delegate
          // Syntactic sugar : you can just do sayHiDelegate()
          sayHiDelegate.Invoke();

          sayHiNameDelegate("Joey");
          
        }

        public static void SayHello()
        {
            Console.WriteLine("Hi there!");
        }

        public static void SayHelloWithName(string name)
        {
            Console.WriteLine($"Hi there Mr. {name}");
        }
    }
}
