using FizzBuzzLib;

namespace FizzBuzzCSharp
{
    public sealed class FizzBuzzUser
    {
        private const int MaxTests = 100;

        private readonly IFizzBuzz fizzBuzz;

        public FizzBuzzUser(IFizzBuzz fizzBuzz)
        {
            this.fizzBuzz = fizzBuzz ?? throw new ArgumentNullException(nameof(fizzBuzz));
        }

        public IEnumerable<string> TestRun1()
        {
            return fizzBuzz.Run(MaxTests);
        }

        public IEnumerable<string> TestRun2()
        {
            return fizzBuzz.Run(Enumerable.Range(1, MaxTests));
        }
    }
}
