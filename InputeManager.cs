namespace MyMathProject
{
    internal class InputeManager
    {
        internal static T RangeInput<T>(T start, T end)
        where T : IParsable<T>, IComparable<T>
        {
            while (true)
            {
                T value = ValidInput<T>();

                if (value.CompareTo(start) < 0 || value.CompareTo(end) > 0)
                {
                    Console.WriteLine($"Please enter a number betwen {start} and {end}!");
                    continue;
                }

                return value;
            }
        }
        internal static T ValidInput<T>() where T : IParsable<T>
        {
            do
            {
                string? input = Console.ReadLine();

                if (!T.TryParse(input, null, out T? value))
                {
                    Console.WriteLine("Please enter a number :");
                    continue;
                }
            } while (true);
        }
    }
}
