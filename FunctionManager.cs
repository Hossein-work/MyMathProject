using MyMathProject;

static class FunctionManager
{
    internal static void FactorialM()
    {
        ConsoleManager.Print("n is :");
        int input = InputeManager.RangeInput(0, int.MaxValue);
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
        ConsoleManager.Print("number one :");
        int a = InputeManager.RangeInput(-int.MaxValue, int.MaxValue);

        ConsoleManager.Print("number two :");
        int b = InputeManager.RangeInput(-int.MaxValue, int.MaxValue);

        long result;
        if (a < 0)
        {
            a *= -1;
            result = MathematicalCalculations.CrossWithPlus(a, b);
            result *= -1;
        }
        else
        {
            result = MathematicalCalculations.CrossWithPlus(a, b);
        }
        ConsoleManager.Print(result.ToString("##,##"), ConsoleColor.Green);
    }
    internal static void ListReverseM()
    {
        List<long> outputList = new List<long>();
        List<long> InputList = new List<long>();
        InputList = GetList();
        InputList.ListReverse(outputList);
        foreach (var item in outputList)
        {
            ConsoleManager.Print(item);
        }

    }
    internal static List<long> GetList()
    {
        ConsoleManager.Print("Please enter number of list elements:");
        int n = InputeManager.RangeInput(0,int.MaxValue);
        List<long> list = new List<long>();
        for (int i = 1; i <= n; i++)
        {
            ConsoleManager.Print($"Please enter amount of element {i}");
            long amount = InputeManager.RangeInput(0, int.MaxValue);
            list.Add(amount);
        }
        return list;
    }
}
