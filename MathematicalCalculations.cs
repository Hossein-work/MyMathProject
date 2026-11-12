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
        internal static long Fibonachi(long x)
        {
            if (x == 1 || x == 2) return 1;
            else return Fibonachi(x - 1) + Fibonachi(x - 2);
        }
        internal static long CrossWithPlus(int x, int y)
        {
            if (x == 0)
                return 0;
            else
                return y + CrossWithPlus(x - 1, y);
        }
    }
}
