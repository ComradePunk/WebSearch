using System.Collections.Generic;
using StringComparator.Interfaces;

namespace StringComparator.Classes
{
    internal class CharByCharComparator : IComparator
    {
        public string Name => "Char-by-char comparator";

        public string[] Compare(string[] input, string[] patterns)
        {
            List<string> result = new List<string>();

            Dictionary<int, HashSet<string>> patternsDictionary = new Dictionary<int, HashSet<string>>();
            foreach (var pattern in patterns)
            {
                int n = pattern.Length;
                if (!patternsDictionary.ContainsKey(n))
                    patternsDictionary[n] = new HashSet<string>();
                if(!patternsDictionary[n].Contains(pattern))
                    patternsDictionary[n].Add(pattern);
            }

            foreach (var str in input)
            {
                int n = str.Length;
                if (!patternsDictionary.ContainsKey(n))
                    continue;
                if(patternsDictionary[n].Contains(str))
                    result.Add(str);
            }

            return result.ToArray();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
