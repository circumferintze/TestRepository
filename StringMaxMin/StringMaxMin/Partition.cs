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
            //bool verif;
            string[] partition = initialString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            string wordMax = "";
            string wordMin = "";
            int n =0;
            int m = partition.Length;
            List<string> allMinWords = new List<string>();
            List<string> allMaxWords = new List<string>();
            foreach (var item in partition)
            {
                if(item.Length > n)
                {
                    wordMax = item;
                    n = item.Length;
                }
                if (item.Length < m)
                {
                    wordMin = item;
                    m = item.Length;
                }
            }
            for (int i = 0; i < partition.Length-1; i++)
            {
                    if (partition[i].Length == n)
                    {

                    allMinWords.Add(partition[i]);
                    }
                if (partition[i].Length == m)
                {

                    allMaxWords.Add(partition[i]);
                }

            }
           

            Console.WriteLine("Words with min legth : ");
            allMinWords.ForEach(a => Console.Write(a));
            Console.WriteLine();
            
            Console.WriteLine("Words with max legth : ");
            allMaxWords.ForEach(a => Console.Write(a));
            

        }
        
    }
}
