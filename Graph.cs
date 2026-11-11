public static class Graph
{
    internal static void GraphColor_Way1(ref int[] vGraph, int[,] eGraph, ref int colorCount)
    {
        if (ElementNoColorExist(vGraph))
        {
            colorCount++;
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
            GraphColor_Way1(ref vGraph, eGraph, ref colorCount);
        }
    }
    internal static void GraphColor_Way2(ref int[] vGraph, int[,] eGraph, ref int colorCount)
    {
        if (ElementNoColorExist(vGraph))
        {
            colorCount++;
            List<int> coloredList = new List<int>();
            int[] saver = GraphColor_Way2Helper(ref vGraph, eGraph, colorCount);
            foreach (var i in saver)
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
            GraphColor_Way2(ref vGraph, eGraph, ref colorCount);
        }
    }
    private static int[] GraphColor_Way2Helper(ref int[] vGraph, int[,] eGraph, int colorCount)
    {
        int[] degrees = new int[vGraph.Length];
        for (int i = 0; i < vGraph.Length; i++)
        {
            for (int j = 0; j < eGraph.Length / 2; j++)
            {
                if (i + 1 == eGraph[0, j])
                    degrees[i]++;
                if (i + 1 == eGraph[1, j])
                    degrees[i]++;
            }
        }
        int[] saver = new int[vGraph.Length];
        for (int i = 0; i < vGraph.Length; i++)
        {
            int index = degrees.IndexOf(degrees.Max());
            degrees[degrees.IndexOf(degrees.Max())] = -1;
            saver[i] = index;
        }
        return saver;
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