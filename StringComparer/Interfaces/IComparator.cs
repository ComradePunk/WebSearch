namespace StringComparator.Interfaces
{
    public interface IComparator
    {
        string Name { get; }
        string[] Compare(string[] input, string[] patterns);
    }
}
