using System;

namespace csharp_playground
{
    public class SimpleMath
    {
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
    }
    public class NonStaticMath
    {
        public int Add(int x, int y) => x + y;
        public int Subtract(int x, int y) => x - y;
    }
    class Program
    {
        /**
        Every delegate has the ability to call their methods synchro or asynchronously with the help of Threads
        delegates can hold one or more methods
        */

        /** The following delegate can point to any method
        taking to in parameters returning an integer
        */
        public delegate int BinaryOp(int x, int y);
        /** Behind the scenes ...
        sealed class BinaryOp : System.MulticastDelegate 
        {
             public int Invoke(int x, int y);

             public IAsyncResult BeginInvoke(int x, int y, 
                  AsyncCallback callback, object state);

             public int EndInvoke(IAsyncResult result);
        }
        */

        static void Main(string[] args)
        {
            BinaryOp op = new BinaryOp(SimpleMath.Add);
            // BinaryOp op;
            // op = SimpleMath.Add;
            var result = op.Invoke(7, 7);
            Console.WriteLine($"7 + 7 = {result}");

            op = SimpleMath.Subtract;
            result = op(10, 20); // without the Invoke()
            Console.WriteLine($"10 - 20 = {result}");

            Delegate[] storedMethods = op.GetInvocationList();
            foreach (Delegate m in storedMethods)
            {
                Console.WriteLine(m.Method);
                // Target is null because it is a static method
                Console.WriteLine(m.Target);
            }

            NonStaticMath n = new NonStaticMath();
            BinaryOp op2 = new BinaryOp(n.Add);
            foreach (Delegate d in op2.GetInvocationList())
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.Target);
            }
        }
    }
}
