using System.Threading.Channels;

namespace MyMathProject
{
    internal static class ConsoleManager
    {
        internal static void Welcome() => Console.WriteLine("---WELCOME TO MY PROGRAM---");
        internal static short FunctionList(string[] list)
        {
            Console.WriteLine("Please enter a number for the operation:");
            for (int i = 0; i < list.Length; i++)
                Console.WriteLine((i+1) + ". " + list[i]);   
            return InputeManager.RangeInput<short>(0, (short)list.Length);
        }
        internal static void Print(string message) => Console.WriteLine(message);
        internal static void Print(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
