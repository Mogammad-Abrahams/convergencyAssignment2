
using System;

namespace Convergency
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] fib = { 2, 0 };
            int i = 0;
            long summed = 0;

            while (fib[i] < 5000000)
            {
                summed += fib[i];
                i = (i + 1) % 2;
                fib[i] = 4 * fib[(i + 1) % 2] + fib[i];
            }
            Console.WriteLine(summed);
        }
    }
}
