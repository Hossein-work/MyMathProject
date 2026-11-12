static partial class Program
{
    static class MatrixCalculations
    {
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
}
