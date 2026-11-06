using System.Runtime.CompilerServices;

static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("""
            Please enter a number for the operation:
            1. Factorial Calculation.
            2. Calculating the nth term of the Fibonacci sequence.
            3. Calculating the multiplication of two numbers.
            4. Reverse a linked list.
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
            case 4:
                List<long> list = new List<long>();
                LinkedListReverse(GetList(), list);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
                break;
        }
    }
    private static List<long> GetList()
    {
        Console.WriteLine("Please enter number of list elements:");
        int n = int.Parse(Console.ReadLine());
        List<long> list = new List<long>();
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Please enter amount of element {i}");
            long amount = long.Parse(Console.ReadLine());
            list.Add(amount);
        }
        return list;
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

    internal static void LinkedListReverse(this List<long> listInput, List<long> outPut)
    {
        if (listInput.Count == 1)
        {
            outPut.Add(listInput[0]);
        }
        else
        {
            outPut.Add(listInput[listInput.Count - 1]);
            listInput.RemoveAt(listInput.Count - 1);
            LinkedListReverse(listInput, outPut);
        }
    }
}