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
            5. Graph Color
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
            case 5:
                Console.WriteLine("Please enter Graph Vertex Count :");
                int vertexCount = int.Parse(Console.ReadLine());
                int[] vGraph = new int[vertexCount];
                Console.WriteLine("Please enter Graph Edge Count:");
                int edgeCount = int.Parse(Console.ReadLine());
                int[,] edges = new int[2, edgeCount];
                for (int i = 0; i < edgeCount; i++)
                {
                    Console.WriteLine($"Please enter the number of vertices of edge {i + 1}");
                    string enter = Console.ReadLine();
                    string[] str = new string[2];
                    str = enter.Split();
                    edges[0, i] = int.Parse(str[0]);
                    edges[1, i] = int.Parse(str[1]);
                }
                Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>();
                int color = 1;
                GraphColor(ref vGraph, edges, ref color, ref dic);
                color--;
                Console.WriteLine(color);
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

    internal static void GraphColor(ref int[] vGraph, int[,] eGraph, ref int colorCount, ref Dictionary<int, List<int>> dic)
    {
        if (ElementNoColorExist(vGraph))
        {
            List<int> coloredList = new List<int>();
            for (int i = 0; i < vGraph.Length; i++)
            {
                if (vGraph[i] == 0)
                {
                    if (CheckX(i + 1, ref eGraph, coloredList))
                    {
                        coloredList.Add(i + 1);
                        vGraph[i] = colorCount;
                    }
                }
            }
            dic[colorCount] = coloredList;
            colorCount++;
            GraphColor(ref vGraph, eGraph, ref colorCount, ref dic);
        }
    }
    private static bool ElementNoColorExist(in int[] vGraph)
    {
        for (int i = 0; i < vGraph.Length; i++)
            if (vGraph[i] == 0) return true;
        return false;
    }
    private static bool CheckX(int x, ref int[,] eGraph, List<int> l)
    {
        for (int i = 0; i < eGraph.Length / 2; i++)
        {
            if (eGraph[0, i] == x)
                if (l.Contains(eGraph[1, i]))
                    return false;
            if (eGraph[1, i] == x)
                if (l.Contains(eGraph[0, i]))
                    return false;
        }
        return true;
    }
}