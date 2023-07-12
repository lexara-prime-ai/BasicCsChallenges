using System;

namespace Fibonacci
{
    class SEQUENCE
    {
        /* STORE INITIAL VALUES */
        // p3 => Sum of two previous terms
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an input: (e.g 10) ");
            int count = Int32.Parse(Console.ReadLine());
            Console.Write($"{p1} {p2}");

            // ITERATE UNTIL THE VALUE OF count IS NO LONGER LESS THAN 2
            for (var i = 2; i < count; i++)
            {
                p3 = p1 + p2;
                Console.Write($" {p3}");
                p1 = p2;
                p2 = p3;
            }
            Console.WriteLine("\nDone...");
        }
    }
}