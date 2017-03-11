using System.Collections.Generic;
using StringComparator.Enums;
using StringComparator.Interfaces;

namespace StringComparator.Classes
{
    public static class ComparatorFactory
    {
        public static IComparator GetComparator(ComparatorType type)
        {
            switch (type)
            {
                case ComparatorType.CharByCharComparator:
                    return new CharByCharComparator();
                case ComparatorType.ContainsComparator:
                    return new ContainsComparator();
                case ComparatorType.EditDistanceComparator:
                    return new EditDistanceComparator();
            }
            return null;
        }

        public static IEnumerable<IComparator> GetAllComparators()
        {
            return new List<IComparator>
            {
                new CharByCharComparator(),
                new ContainsComparator(),
                new EditDistanceComparator()
            };
        }
    }
}
