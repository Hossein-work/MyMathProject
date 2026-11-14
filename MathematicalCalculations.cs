using System.Numerics;

namespace MyMathProject
{
    internal static class MathematicalCalculations
    {
        internal static long Factorial(long x)
        {
            if (x == 0)
                return 1;
            else
                return x * Factorial(x - 1);
        }
        /*internal static long Fibonachi(int x)
        {
            if (x == 1 || x == 2) return 1;
            else return Fibonachi(x - 1) + Fibonachi(x - 2);
        }*/
        internal static long CrossWithPlus(int x, int y)
        {
            if (x == 0)
                return 0;
            else
                return y + CrossWithPlus(x - 1, y);
        }
        internal static BigInteger Fibonachi(int x)
        {
            x -= 2;// There are two 1's.
            BigInteger[] list = { 1, 1 };
            int counter = 0;
            while (counter != x)
            {
                list[counter % 2] = list[0] + list[1];
                counter++;
            }
            return list.Max();
        }

    }
}
