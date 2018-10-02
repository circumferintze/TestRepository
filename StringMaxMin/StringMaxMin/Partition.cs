using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMaxMin
{
    public class Partition : IPartition
    {
        private string initialString;
        private char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
        private string[] partition;

        public Partition(string input)
        {
            this.initialString = input;
        }

        public IEnumerable<string> GetShortestWords()
        {
            return GetWordsForStrategy((n, o) => n < o);
        }

        public IEnumerable<string> GetLongestWords()
        {
            return GetWordsForStrategy((n, o) => n > o);
        }

        private IEnumerable<string> GetWordsForStrategy(Func<int, int, bool> condition)
        {
            if (partition == null || !partition.Any())
                partition = initialString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            if (!partition.Any())
                return Enumerable.Empty<string>();

            string wordMax = partition.First();
            int previousExtremeValue = wordMax.Length;
            foreach (var item in partition)
            {
                if (condition.Invoke(item.Length, previousExtremeValue))
                {
                    wordMax = item;
                    previousExtremeValue = item.Length;
                }
            }

            List<string> allMaxWords = new List<string>();
            for (int i = 0; i < partition.Length; i++)
            {
                if (partition[i].Length == previousExtremeValue)
                    allMaxWords.Add(partition[i]);
            }
            List<string> allMaxWordsFinal = allMaxWords.Distinct().ToList();
            return allMaxWordsFinal;
        }
    }

    internal class PartitionFactory
    {
        public IPartition GetPartition(IStringProvider stringProvider)
        {
            return new Partition(stringProvider.GetValue());
        }

        public IPartition GetPartition(string value)
        {
            return new Partition(value);
        }
    }
}
