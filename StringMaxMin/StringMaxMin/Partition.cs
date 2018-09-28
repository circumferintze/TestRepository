using System;
using System.Collections.Generic;
using System.Text;

namespace StringMaxMin
{
    public class Partition
    {
        public string initialString;
        public char[] delimiters = new char[] { ' ', ',', '.', '!', '?', ':', ';' };
        public Partition(string input)
        {
            this.initialString = input;
        }

        public void PartitionOfString()
        {
            bool verif;
            string[] partition = initialString.Split(delimiters);
            foreach (var item in partition)
            {
                Console.WriteLine($"{item}, {item.Length}");
            }
            do
            {
                verif = false;
                for (int i = 0; i < partition.Length; i++)
                {
                    if (partition[i].Length > partition[i + 1].Length)
                    { }
                }
                
            } while (verif);
            
        }
        
        /*public void CompareLength ()
        {


        }
        */
    }
}
