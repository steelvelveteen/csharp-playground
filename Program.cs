using System.IO;
using System.Runtime.CompilerServices;
using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = DoMath(5,5, MathType.Multiply);
            var result = DoModernMath(5, 5, MathType.Multiply);
            Console.WriteLine(result);
        }
        enum MathType
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }
        // Traditional switch
        static double DoMath(double x, double y, MathType mathType)
        {
            double output = 0;
            switch (mathType)
            {
                case MathType.Add:
                    output = x + y;
                    break;
                case MathType.Subtract:
                    output = x - y;
                    break;
                case MathType.Multiply:
                    output = x * y;
                    break;
                case MathType.Divide:
                    output = x / y;
                    break;
            }
            return output;
        }

        //  C# 8.0 switch expression
        // This is very similar to a match or if expression
        // as right hand value in Rust. Same thing!!
        // Really cool feature
        static double DoModernMath(double x, double y, MathType mathType)
        {
            var output = mathType switch
            {
                MathType.Add => x * y,
                MathType.Subtract => x - y,
                MathType.Multiply => x * y,
                MathType.Divide => x / y,
                _ => throw new Exception("Bad math type passed in")
            };

            return output;
        }
    }
}
