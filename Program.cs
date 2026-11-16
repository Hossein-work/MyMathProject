using MyMathProject;
static partial class Program
{
    static string[] functionList = 
    {
         "Factorial Calculation.",
         "Calculating the nth term of the Fibonacci sequence.",
         "Calculating the multiplication of two numbers.",
         "Reverse a linked list.",
         "Graph Color",
         "Calculation Determinant for any matrix."
    };
    static void Main(string[] args)
    {
        ConsoleManager.Welcome();
        short input = ConsoleManager.FunctionList(functionList);
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
                FunctionManager.ListReverseM();
                break;
            case 5:
                FunctionManager.GraphColorM();            
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
                
                Console.WriteLine(MatrixCalculations.MatrixDeterminant(matrix, rowAndColumn, determinant));
                break;
        }
    }

}
