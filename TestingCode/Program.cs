using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;


namespace TestingCode
{
    class Program
    {
        public delegate int Del(int x, int y);

        static int Calculate(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine("Calculate method : " + sum);
            return sum;
        }

        static void CalculationDone(IAsyncResult res)
        {
            Thread.Sleep(1000);
            Del d = ((AsyncResult) res).AsyncDelegate as Del;
            int sum = d.EndInvoke(res);
            Console.WriteLine("Callback method : " + sum);
        }

        public static void Main(string[] args)
        {
            Del d = Calculate;
            d.BeginInvoke(3, 4, CalculationDone, null);
            Console.WriteLine("End");
            Console.ReadLine();
        }
    }
}
