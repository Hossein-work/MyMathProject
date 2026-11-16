using MyMathProject;
using System.Numerics;

static class FunctionManager
{
    internal static void FactorialM()
    {
        ConsoleManager.Print("n is :");
        short input = InputeManager.RangeInput<short>(0, short.MaxValue);
        BigInteger result = MathematicalCalculations.Factorial(input);
        ConsoleManager.Print(result.ToString("##,##"), ConsoleColor.Green);
    }
    internal static void FibonachiM()
    {
        ConsoleManager.Print("n is :");
        int input = InputeManager.RangeInput(0, int.MaxValue);
        BigInteger result = MathematicalCalculations.Fibonachi(input);
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

    internal static void GraphColorM()
    {
        ConsoleManager.Print("Please enter Graph Vertex Count :");
        int vertexCount = InputeManager.RangeInput(1,int.MaxValue);
        
        ConsoleManager.Print("Please enter Graph Edge Count:");
        int edgeCount = InputeManager.RangeInput(1, int.MaxValue);
        
        for (int i = 0; i < edgeCount; i++)
        {
            ConsoleManager.Print($"Please enter the number of vertices of edge {i + 1}");
            string enter = Console.ReadLine();
            string[] str = new string[2];
            str = enter.Split();
            edges[0, i] = int.Parse(str[0]);
            edges[1, i] = int.Parse(str[1]);
        }
        int color1 = 0;
        Graph.GraphColor_Way1(ref vGraph, edges, ref color1);
        ConsoleManager.Print(color1);


        int color2 = 0;
        for (int i = 0; i < vGraph.Length; i++)
        {
            vGraph[i] = 0;
        }
        Graph.GraphColor_Way2(ref vGraph, edges, ref color2);
        ConsoleManager.Print(color2);
    }
    
}
