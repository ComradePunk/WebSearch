using System;

namespace StringComparator.Extentions
{ 
    public static class StringExtentions
    {
        public static bool KmpContains(this string self, string str)
        {
            // Knuth–Morris–Pratt algorithm
            self = self[0] + self;
            int[] result = new int[self.Length];
            result[0] = 0;

            for (int i = 1; i < self.Length; i++)
            {
                int j = result[i - 1];
                while (j > 0 && self[i] != str[j])
                    j = result[j - 1];
                if (self[i] == str[j]) ++j;
                result[i] = j;
                if(j == str.Length)
                    return true;
            }
            return false;
        }

        public static int EditDistance(this string self, string other)
        {
            // 'Levenshtein distance' algorithm
            string first, second;
            if (self.Length > other.Length)
            {
                first = other;
                second = self;
            }
            else
            {
                first = self;
                second = other;
            }

            int[,] distance = new int[2, second.Length + 1];
            distance[0, 0] = 0;
            distance[1, 0] = 1;

            for (int i = 1; i <= second.Length; i++)
                distance[0, i] = i;

            for (int i = 1; i <= first.Length; i++)
                for (int j = 1; j <= second.Length; j++)
                {
                    if (first[i - 1] == second[j - 1])
                        distance[i % 2, j] = distance[(i - 1) % 2, j - 1];
                    else distance[i % 2, j] = Math.Min(distance[(i - 1) % 2, j], Math.Min(distance[i % 2, j - 1], distance[(i - 1) % 2, j - 1])) + 1;
                }
            return distance[first.Length % 2, second.Length];
        }
    }
}
