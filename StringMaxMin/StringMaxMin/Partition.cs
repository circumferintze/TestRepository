using System;
using System.Collections.Generic;
using System.Linq;

namespace StringMaxMin
{
    public class Partition
    {
        public string initialString;
        public char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
        public string[] partition;
        public Partition(string input)
        {
            this.initialString = input;
        }
        public string[] PartitionOfWords()
        {
        string[] partition = initialString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
        return partition;
        }
        public List<string> ReturnWordsWithMinimumLength()
        { 
            string wordMin = "";
            int m = partition.Length;
            List<string> allMinWords = new List<string>();
            foreach (var item in partition)
            {
                if(item.Length < m)
                {
                    wordMin = item;
                    m = item.Length;
                }
            }
            for (int i = 0; i < partition.Length; i++)
            { 
                if (partition[i].Length == m)
                    allMinWords.Add(partition[i]);
            }
            List<string> allMinWordsFinal = allMinWords.Distinct().ToList();
            return allMinWordsFinal;
        }
        public List<string> ReturnWordsWithMaximumLength()
        {
            string wordMax = "";
            int n = 0;
            List<string> allMaxWords = new List<string>();
            foreach (var item in partition)
            {
                if (item.Length > n)
                {
                    wordMax = item;
                    n = item.Length;
                }
            }
            for (int i = 0; i < partition.Length; i++)
            {
                if (partition[i].Length == n)
                    allMaxWords.Add(partition[i]);
            }
            List<string> allMaxWordsFinal = allMaxWords.Distinct().ToList();
            return allMaxWordsFinal;
        }

    }
}
