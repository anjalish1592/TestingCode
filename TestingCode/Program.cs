using System;
using System.Globalization;
using System.Threading;

namespace TestingCode
{
    class Program
    {
        public delegate int delegateDemo(int a, int b);

        static int Sum(int x, int y)
        {
            var z = x + y;
            Console.WriteLine("Sum() = " + z);
            return z;
        }

        static void Main(string[] args)
        {
            delegateDemo d = Sum;
            IAsyncResult result = d.BeginInvoke(2, 3, null, null);
            int sum = d.EndInvoke(result);
            Console.WriteLine("Main() = " + sum);
            Console.ReadLine();
        }
    }
}
