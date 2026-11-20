using MyMathProject;
static class Program
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
                FunctionManager.MatrixDeterminantM();
                break;
        }
    }

}
