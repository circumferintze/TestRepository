using System;
using System.Collections.Generic;
using System.Text;

namespace StringMaxMin
{
    public class Partition
    {
        public string initialString = "Un nou rasarit, o noua zi";
        public char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
        public Partition(string input)
        {
            this.initialString = input;
        }

        public void PartitionOfString()
        {
            string[] partition = initialString.Split(delimiters);
            foreach (var item in partition)
            {
                Console.WriteLine(item);
            }
        }
    }
}
