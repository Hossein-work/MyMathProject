using MyMathProject;

public static class GraphCalCulations
{   
    internal static void GraphColor_Way1(ref Graph graph,ref int colorCount)
    {
        if (ElementNoColorExist(graph.vGraph))
        {
            colorCount++;
            List<int> coloredList = new List<int>();
            for (int i = 0; i < graph.vGraph.Length; i++)
            {
                if (graph.vGraph[i] == 0)
                {
                    if (CheckX(i + 1, ref graph.edges, coloredList))
                    {
                        coloredList.Add(i + 1);
                        graph.vGraph[i] = colorCount;
                    }
                }
            }
            GraphColor_Way1(ref graph, ref colorCount);
        }
    }
    internal static void GraphColor_Way2(ref Graph graph, ref int colorCount)
    {
        if (ElementNoColorExist(graph.vGraph))
        {
            colorCount++;
            List<int> coloredList = new List<int>();
            int[] saver = GraphColor_Way2Helper(ref graph, colorCount);
            foreach (var i in saver)
            {
                if (graph.vGraph[i] == 0)
                {
                    if (CheckX(i + 1, ref graph.edges, coloredList))
                    {
                        coloredList.Add(i + 1);
                        graph.vGraph[i] = colorCount;
                    }
                }
            }
            GraphColor_Way2(ref graph, ref colorCount);
        }
    }
    private static int[] GraphColor_Way2Helper(ref Graph graph, int colorCount)
    {
        int[] degrees = new int[graph.vGraph.Length];
        for (int i = 0; i < graph.vGraph.Length; i++)
        {
            for (int j = 0; j < graph.edges.Length / 2; j++)
            {
                if (i + 1 == graph.edges[0, j])
                    degrees[i]++;
                if (i + 1 == graph.edges[1, j])
                    degrees[i]++;
            }
        }
        int[] saver = new int[graph.vGraph.Length];
        for (int i = 0; i < graph.vGraph.Length; i++)
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