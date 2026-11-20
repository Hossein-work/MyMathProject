namespace MyMathProject
{
    internal class InputeManager
    {
        internal static T RangeInput<T>(T start, T end)
        where T : IParsable<T>, IComparable<T>
        {
            ConsoleManager.Print($"({start} until {end})", ConsoleColor.White);
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

        internal static T[] GetTwoInput<T>(T start, T end)
        where T : IParsable<T>, IComparable<T>
        {
            string? input;
            string[] str = new string[2];
            T[] result = new T[str.Length];
            ConsoleManager.Print($"Please enter a number betwen {start} and {end}!", ConsoleColor.White);
            while (true)
            {
                do
                {
                    ConsoleManager.Print("Please enter two number : (x y)",ConsoleColor.Yellow);
                    input = Console.ReadLine();
                    str = input.Split();

                } while (str.Length != 2);
                try
                {
                    result[0] = T.Parse(str[0], null);
                    result[1] = T.Parse(str[1], null);
                    if ((result[0].CompareTo(start) < 0 || result[0].CompareTo(end) > 0)
                        && (result[1].CompareTo(start) < 0 || result[1].CompareTo(end) > 0))
                        ConsoleManager.Print($"Please enter a number betwen {start} and {end}!", ConsoleColor.Red);
                    else
                        return result;
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
