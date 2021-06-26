using System;

namespace Program
{
    class Program
    {
        static int fibonacci(int n)
        {
            if (n <= 1)
                return n;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        // Returns number of ways
        // to reach n'th stair
        static int countWays(int s)
        {
            return fibonacci(s + 1);
        }

        static public void Main()
        {
            int s = 9;
            Console.WriteLine("Number of ways = " + countWays(s));
        }
    }
}
