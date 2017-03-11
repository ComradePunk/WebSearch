using System.Collections.Generic;
using System.Linq;
using StringComparator.Extentions;
using StringComparator.Interfaces;

namespace StringComparator.Classes
{
    internal class EditDistanceComparator : IComparator
    {
        public string Name => "Edit distance comparator";

        private void CheckInput(string input, HashSet<string> patterns, List<string> result)
        {
            if (patterns.Select(input.EditDistance).Any(editDistance => editDistance == 0 || editDistance == 1))
                result.Add(input);
        }

        public string[] Compare(string[] input, string[] patterns)
        {
            List<string> result = new List<string>();

            Dictionary<int, HashSet<string>> patternsDictionary = new Dictionary<int, HashSet<string>>();
            foreach (var pattern in patterns)
            {
                int n = pattern.Length;
                if (!patternsDictionary.ContainsKey(n))
                    patternsDictionary[n] = new HashSet<string>();
                if (!patternsDictionary[n].Contains(pattern))
                    patternsDictionary[n].Add(pattern);
            }

            foreach (var str in input)
            {
                int n = str.Length;
                for (int i = n - 1; i <= n + 1; i++)
                    if (patternsDictionary.ContainsKey(i))
                        CheckInput(str, patternsDictionary[i], result);
            }

            return result.ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
