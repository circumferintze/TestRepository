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

        public void PartitionOfString()
        {
            string[] partition = initialString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string wordMax = "";
            string wordMin = "";
            int n = 0;
            int m = partition.Length;
            List<string> allMinWords = new List<string>();
            List<string> allMaxWords = new List<string>();
            foreach (var item in partition)
            {
                if(item.Length < m)
                {
                    wordMin = item;
                    m = item.Length;
                }
                if (item.Length > n)
                {
                    wordMax = item;
                    n = item.Length;                   
                }
            }
            for (int i = 0; i < partition.Length; i++)
            {
                if (partition[i].Length == m)
                    {
                    allMinWords.Add(partition[i]);
                    }
                if (partition[i].Length == n)
                {
                    allMaxWords.Add(partition[i]);
                }

            }
            List<string> allMinWordsFinal = allMinWords.Distinct().ToList();
            List<string> allMaxWordsFinal = allMaxWords.Distinct().ToList();

           allMinWordsFinal.PrintCollection();
           allMaxWordsFinal.PrintCollection();
            

        }
        
    }
}
