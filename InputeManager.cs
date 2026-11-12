using System;
using System.Collections.Generic;
using System.Text;

namespace MyMathProject
{
    internal class InputeManager
    {
        internal static int RangeInput(int start, int end)
        {
            int b;
            do
            {
                b = ValidInput();
                if (b < start || b > end)
                    Console.WriteLine($"The entered value must be between {start} and {end}!");
                else return b;
            } while (true);
        }
        internal static int ValidInput()
        {
            int output;
            do
            {
                if (int.TryParse(Console.ReadLine(), out output))
                    break;
                Console.WriteLine("Please enter a number!");
            } while (true);
            return output;
        }
    }
}
