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
            List<string> partition = initialString.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            string word = "";
            int n =0;
            foreach (var item in partition)
            {
                if(item.Length > n)
                {
                    word = item;
                    n = item.Length;
                }
            }
            //var afterPartition = partition.Where(w => w.Length != 0).ToList();
            /*var minWord = afterPartition.Where(w => w.Length == afterPartition.Min(x => x.Length)).ToList();
            var maxWord = afterPartition.Where(w => w.Length == afterPartition.Max(y => y.Length)).ToList();*/

            /*Console.WriteLine("Words with min legth : ");
            minWord.ForEach(a => Console.Write(a + " "));
            Console.WriteLine();
            Console.WriteLine("Words with max legth : ");
            maxWord.ForEach(a => Console.Write(a + " "));
            */

            /*
            do
            {
                verif = false;
                string temp;
                for (int i = 0; i < partition.Length-1; i++)
                {
                    if (partition[i].Length > partition[i + 1].Length)
                    {
                        temp = partition[i];
                        partition[i] = partition[i + 1];
                        partition[i + 1] = temp;
                        verif = true;
                    }
                }    
            } while (verif);
            var first = partition.First();
            var last = partition.Last();
            Console.WriteLine($"Word with minimal length is {first}, \b Word with maximal length is  {last}");
            return partition;*/
        }
        
    }
}
