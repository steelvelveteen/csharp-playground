using System;

namespace csharp_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The params keyword");
            // Similar to the spread / rest operator in javascript.
            // You don't know how many arguments the function/method will receive
            // so you use the params keyword.
            Console.WriteLine("1 + 2 + 5 = {0}", GetSumWithParams(1, 2, 5));
            Console.WriteLine();

            Console.WriteLine("The out parameter");
            // You call the method passing an out parameter 
            // which is basically a ref to the solution variable
            // The methood's signature takes in a argument of type 'out int'
            // and this method DOES NOT RETURN ANYTHING

            // int solution;
            // DoubleIt(25, out solution); 

            // Or you do it in a one-statement declaration as below
            DoubleIt(25, out int solution);
            Console.WriteLine($"Double of 25: {solution}");
            Console.WriteLine();

            Console.WriteLine("Passing by reference");
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine("Before swapping num1: {0}, num2: {1}", num1, num2);
            Swap(ref num1, ref num2);
            Console.WriteLine("After swapping num1: {0}, num2: {1}", num1, num2);

        }

        static double GetSumWithParams(params double[] nums)
        {
            double sum = 0;
            foreach (int i in nums)
            {
                sum += i;
            }
            return sum;
        }

        static void DoubleIt(int x, out int solution) => solution = x * 2;
        // {
        //     solution = x * 2;
        // }

        static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
