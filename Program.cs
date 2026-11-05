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
        }
    }
    internal static long Factorial(long x)
    {
        if (x == 0)
            return 1;
        else
            return x * Factorial(x - 1);
    }
   
}