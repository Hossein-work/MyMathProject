namespace MyMathProject
{
    internal class InputeManager
    {
        internal static T RangeInput<T>(T start, T end)
        where T : IParsable<T>, IComparable<T>
        {
            ConsoleManager.Print($"Please enter a number betwen {start} and {end}!", ConsoleColor.White);
            while (true)
            {
                string? input = Console.ReadLine();
                try
                {
                    T value = T.Parse(input, null);
                    if (value.CompareTo(start) < 0 || value.CompareTo(end) > 0)
                    {
                        ConsoleManager.Print($"Please enter a number betwen {start} and {end}!", ConsoleColor.Red);
                    }
                    else
                        return value;
                }
                catch (OverflowException)
                {
                    ConsoleManager.Print($"Please enter a number betwen {start} and {end}!", ConsoleColor.Red);
                }
                catch
                {
                    ConsoleManager.Print("Please enter the valid value :", ConsoleColor.Red);
                }


            }
        }
    }
}
