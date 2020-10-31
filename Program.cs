using System;

namespace csharp_playground
{
    // Revisit delegate complex example branch
    class Program
    {
        delegate int Operation(int a, int b);
        delegate void Operation2(int a, int b);
        delegate int Operation3(int a, int b);
        delegate int Operation4(int a, int b);

        static void Main(string[] args)
        {
            Operation op = Add;
            int result = op.Invoke(4, 5);
            Console.WriteLine($"4 + 5 = {result}");

            // Using anonymous method
            Operation2 op2 = delegate (int a, int b)
            {
                Console.WriteLine(a - b);
            };
            op2(10, 5);

            // lambda expression
            Operation3 op3 = (a, b) => a * b;
            int result3 = op3(5, 4);
            Console.WriteLine($"5 * 4 = {result3}");

            // Statement lambda
            Operation4 op4 = (a, b) => {
                // do something more before returning
                return a * b;
            };
            int result4 = op4(6, 6);
            Console.WriteLine($"6 * 6 = {result4}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
