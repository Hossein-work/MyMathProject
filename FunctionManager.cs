using MyMathProject;

static class FunctionManager
{
    internal static void FactorialM()
    {
        ConsoleManager.Print("n is :");
        int input = InputeManager.RangeInput(0,int.MaxValue);
        long result = MathematicalCalculations.Factorial(input);
        ConsoleManager.Print(result.ToString("##,##"), ConsoleColor.Green);
    }
    internal static void FibonachiM()
    {
        ConsoleManager.Print("n is :");
        int input = InputeManager.RangeInput(0, int.MaxValue);
        long result = MathematicalCalculations.Fibonachi(input);
        ConsoleManager.Print(result.ToString("##,##"), ConsoleColor.Green);
    }
    internal static void CrossWithPlusM()
    {
        int a = InputeManager.ValidInput<int>();
        int b = InputeManager.ValidInput<int>();
        long result = MathematicalCalculations.CrossWithPlus(a, b);
        ConsoleManager.Print(result.ToString("##,##"),ConsoleColor.Green);
    }
}
