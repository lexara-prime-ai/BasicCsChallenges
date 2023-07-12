using System;

namespace FIBONACCI
{
    class SEQUENCE
    {
        /* INITIAL VALUES  */
        static int p1 = 0, p2 = 1, p3;
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an input value: (e.g 10) ");
            // READ INPUT VALUE AND CONVERT IT TO AN INTEGER
            int count = Int32.Parse(Console.ReadLine());
            // PRINT THE INITIAL VALUES IN THE SEQUENCE i.e 0, 1, 1
            Console.Write($"{p1} {p2}");

            // ITERATE UNTIL THE VALUE OF count IS NO LONGER GREATER THAN i
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