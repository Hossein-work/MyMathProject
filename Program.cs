static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("""
            Please enter a number for the operation:
            1. Factorial Calculation.
            2. Calculating the nth term of the Fibonacci sequence.
            3. Calculating the multiplication of two numbers.
            """);
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                Console.WriteLine(Factorial(long.Parse(Console.ReadLine())).ToString("##,##"));
                break;
            case 2:
                Console.WriteLine(Fibonachi(long.Parse(Console.ReadLine())).ToString("##,##"));
                break;
            case 3:
                long a = long.Parse(Console.ReadLine());
                long b = long.Parse(Console.ReadLine());
                Console.WriteLine(CrossWithPlus(a, b));
                break;
        }
    }
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
    internal static long CrossWithPlus(long x, long y)
    {
        if (x == 0)
            return 0;
        else
            return y + CrossWithPlus(x - 1, y);
    }

}