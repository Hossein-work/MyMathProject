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
            6. Calculation Determinant for any matrix.
            """);
        int input = int.Parse(Console.ReadLine());
        switch (input)
        {
            case 1:
                FunctionManager.FactorialM();
                break;
            case 2:
                FunctionManager.FibonachiM();
                break;
            case 3:
                FunctionManager.CrossWithPlusM();
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
                int color1 = 0;
                Graph.GraphColor_Way1(ref vGraph, edges, ref color1);
                Console.WriteLine(color1);


                int color2 = 0;
                for (int i = 0; i < vGraph.Length; i++)
                {
                    vGraph[i] = 0;
                }
                Graph.GraphColor_Way2(ref vGraph, edges, ref color2);
                Console.WriteLine(color2);
                break;
            case 6:
                Console.WriteLine("Please enter the number of row and column for square matrix :");
                int rowAndColumn = int.Parse(Console.ReadLine());
                List<long> matrix = new List<long>();
                for (int i = 0; i < rowAndColumn; i++)
                {
                    for (int j = 0; j < rowAndColumn; j++)
                    {
                        Console.WriteLine($"Please enter row {i + 1} and column {j + 1} element :");
                        long element = long.Parse(Console.ReadLine());
                        matrix.Add(element);
                    }
                }
                long determinant = 0;
                
                Console.WriteLine(MatrixDeterminant(matrix, rowAndColumn, determinant));
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
    internal static long MatrixDeterminant(List<long> m, int rowAndColumn, long determinant)
    {
        determinant = 0;
        if (m.Count == 4)
            return m[0] * m[3] - m[1] * m[2];
        else
        {

            List<long> tmp = new List<long>();
            for (int i = 0; i < rowAndColumn; i++)
            {
                int rowAndColumnNewMatrix = rowAndColumn - 1;
                List<long> longList = MinimalMatrix(m, i, rowAndColumn);
                long DMM = MatrixDeterminant(longList, rowAndColumnNewMatrix, determinant);
                tmp.Add(m[i] * (long)Math.Pow(-1, i) * DMM);
            }
            determinant += tmp.Sum();
        }

        return determinant;
    }
    private static List<long> MinimalMatrix(List<long> m, int c, int rowAndColumn)//c is coloum
    {
        List<long> minimalM = new List<long>();
        for (int i = 0; (i < rowAndColumn); i++)
            if (i != c)
                for (int j = i; j < m.Count; j += rowAndColumn)
                {
                    if (j != i)
                    {
                        minimalM.Add(m[j]);
                    }
                }
        return minimalM;
    }

}
