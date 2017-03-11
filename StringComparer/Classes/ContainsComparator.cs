using System.Linq;
using StringComparator.Extentions;
using StringComparator.Interfaces;

namespace StringComparator.Classes
{
    internal class ContainsComparator : IComparator
    {
        public string Name => "Contains comparator";

        public string[] Compare(string[] input, string[] patterns)
        {
            return input.Where(str => patterns.Any(str.KmpContains)).ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
