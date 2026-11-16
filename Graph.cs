namespace MyMathProject
{
    internal class Graph
    {
        internal int[] vGraph;
        internal int[,] edges;
        public Graph(int vertexCount, int edgeCount)
        {
            vGraph = new int[vertexCount];
            edges = new int[2, edgeCount];
        }
    }
}
