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
        int n = InputeManager.RangeInput(0, int.MaxValue);
        List<long> list = new List<long>();
        for (int i = 1; i <= n; i++)
        {
            ConsoleManager.Print($"Please enter amount of element {i}");
            long amount = InputeManager.RangeInput(0, int.MaxValue);
            list.Add(amount);
        }
        return list;
    }
    private static Graph GetGraph()
    {
        ConsoleManager.Print("Please enter Graph Vertex Count :");
        int vertexCount = InputeManager.RangeInput(1, int.MaxValue);

        ConsoleManager.Print("Please enter Graph Edge Count:");
        int edgeCount = InputeManager.RangeInput(1, int.MaxValue);
        Graph graph = new Graph(vertexCount, edgeCount);
        for (int i = 0; i < edgeCount; i++)
        {
            ConsoleManager.Print($"Please enter the number of vertices of edge {i + 1}");
            int[] number = InputeManager.GetTwoInput<int>(1, vertexCount);
            graph.edges[0, i] = number[0];
            graph.edges[1, i] = number[1];
        }
        return graph;
    }
    internal static void GraphColorM()
    {
        Graph graph = GetGraph();
        int color1 = 0;
        GraphCalCulations.GraphColor_Way1(ref graph, ref color1);
        ConsoleManager.Print(color1);


        int color2 = 0;
        for (int i = 0; i < graph.vGraph.Length; i++)
        {
            graph.vGraph[i] = 0;
        }
        GraphCalCulations.GraphColor_Way2(ref graph, ref color2);
        ConsoleManager.Print(color2);
    }

    internal static void MatrixDeterminantM()
    {
        ConsoleManager.Print("Please enter the number of row and column for square matrix :");
        int rowAndColumn = InputeManager.RangeInput(1,short.MaxValue);
        List<long> matrix = new List<long>();
        for (int i = 0; i < rowAndColumn; i++)
        {
            for (int j = 0; j < rowAndColumn; j++)
            {
                ConsoleManager.Print($"Please enter row {i + 1} and column {j + 1} element :");
                long element = InputeManager.RangeInput(1, short.MaxValue);
                matrix.Add(element);
            }
        }
        long determinant = 0;
        long outPut = MatrixCalculations.MatrixDeterminant(matrix, rowAndColumn, determinant);
        ConsoleManager.Print(outPut);
    }
}
