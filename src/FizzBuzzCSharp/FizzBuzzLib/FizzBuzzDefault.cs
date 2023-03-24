namespace FizzBuzzLib
{
    public sealed class FizzBuzzDefault : IFizzBuzz
    {
        public IEnumerable<string> Run(int max)
        {
            var result = new List<string>();

            for (int i = 1; i <= max; i++)
            {
                result.Add(GetString(i));
            }

            return result;
        }

        public IEnumerable<string> Run(IEnumerable<int> values)
        {
            return values.Select(i => GetString(i));
        }

        private static string GetString(int i)
        {
            if (IsFizzBuzz(i))
            {
                return "FizzBuzz";
            }

            if (IsFizz(i))
            {
                return "Fizz";
            }

            if (IsBuzz(i))
            {
                return "Buzz";
            }

            return i.ToString();
        }

        private static bool IsFizz(int value)
        {
            return value % 3 == 0;
        }

        private static bool IsBuzz(int value)
        {
            return value % 5 == 0;
        }

        private static bool IsFizzBuzz(int value)
        {
            return IsFizz(value) && IsBuzz(value);
        }
    }
}
