﻿namespace OPERATIONS
{
    class NUMBER_OPERATIONS
    {
        static void Main()
        {
            /* PRINT ODD NUMBERS */
            Console.WriteLine("NUMBER OPERATIONS\n***Generate Odd Numbers***\nPlease provide a range: ");
            GENERATE_ODD_NUMBERS();

            Console.WriteLine("\nProceed to generate Even Numbers or press Ctrl + C to exit...");

            /* PRINT EVEN NUMBERS */
            Console.WriteLine("\nPlease provide a range: ");
            GENERATE_EVEN_NUMBERS();

            Console.WriteLine("Proceed to generate Fizz Buzz Sequence or press Ctrl + C to exit...");

            /* PRINT FIZZ BUZZ SEQUENCE */
            Console.WriteLine("\nPlease provide a range: ");
            GENERATE_FIZZ_BUZZ_SEQUENCE();

            /* CALCULATE FACTORIAL */
            Console.WriteLine("Proceed to Calculate Factorial or press Ctrl + C to exit...");
            FACTORIAL();
        }

        /* GET USER INPUT */
        static (int START, int END) GET_USER_INPUT()
        {
            int START = Int32.Parse(Console.ReadLine());
            int END = Int32.Parse(Console.ReadLine());

            /* CHECK IF SECOND VALUE IS LESS THAN THE FIRST VALUE */
            if (END < START)
            {
                throw new Exception("\nERROR: Second value must be greater than first value...");
            }
            return (START, END);
        }

        /* GENERATE ODD NUMBERS */
        static void GENERATE_ODD_NUMBERS()
        {
            (int START, int END) userInput = GET_USER_INPUT();
            Console.WriteLine(
                $"Printing Odd Numbers using the provided range({userInput.START} {userInput.END}): "
            );

            for (var i = userInput.START; i < userInput.END; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        /* GENERATE EVEN NUMBERS */
        static void GENERATE_EVEN_NUMBERS()
        {
            (int START, int END) userInput = GET_USER_INPUT();
            Console.WriteLine(
                $"Printing Even Numbers using the provided range({userInput.START} {userInput.END}): "
            );

            for (var i = userInput.START; i < userInput.END; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }

        /* APPEND fizz | buzz TO NUMBERS DIVISIBLE BY 3 & 5 TO */
        static void GENERATE_FIZZ_BUZZ_SEQUENCE()
        {
            (int START, int END) userInput = GET_USER_INPUT();
            Console.WriteLine(
                $"Printing Even Numbers using the provided range({userInput.START} {userInput.END}): "
            );

            for (var i = userInput.START; i < userInput.END; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}: fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}: buzz");
                }
                else
                {
                    Console.WriteLine($"{i}: fizzbuzz");
                }
            }
        }

        /* CALCULATE FACTORIAL */
        static void FACTORIAL()
        {
            // FORMULA: n! = n * (n-1)
            int INPUT = Int32.Parse(Console.ReadLine());
            /* CHECK IF INPUT IS A NEGATIVE VALUE */
            if (INPUT < 0)
            {
                throw new Exception("Negative numbers are not allowed!");
            }

            /* INITIALIZE OUTPUT TO 1 SINCE 0! AND 1! ARE EQUAL TO 1 */
            int OUTPUT = 1;

            for (int index = 1; index <= INPUT; index++)
            {
                OUTPUT *= index;
            }
            
            Console.WriteLine($"FACTORIAL OF {INPUT}: {OUTPUT}");
        }
    }
}