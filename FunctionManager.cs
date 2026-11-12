using MyMathProject;

static class FunctionManager
{
    internal static void FactorialM()
    {
        Console.WriteLine("n is :");
        int input = InputeManager.RangeInput(0,int.MaxValue);
        long result = MathematicalCalculations.Factorial(input);
        Console.WriteLine(result.ToString("##,##"));
    }
    internal static void FibonachiM()
    {
        Console.WriteLine("n is :");
        int input = InputeManager.RangeInput(0, int.MaxValue);
        long result = MathematicalCalculations.Fibonachi(input);
        Console.WriteLine(result.ToString("##,##"));
    }
    internal static void CrossWithPlusM()
    {
        int a = InputeManager.ValidInput<int>();
        int b = InputeManager.ValidInput<int>();
        long result = MathematicalCalculations.CrossWithPlus(a, b);
        Console.WriteLine(result.ToString("##,##"));
    }
}
