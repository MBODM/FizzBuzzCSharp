namespace FizzBuzzLib
{
    public interface IFizzBuzz
    {
        IEnumerable<string> Run(int max);
        IEnumerable<string> Run(IEnumerable<int> values);
    }
}
