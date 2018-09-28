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
                foreach (var item in partition)
                {
                    Console.WriteLine($"{item}");
                }
                
                
            } while (verif);
                }
        
        /*public void CompareLength ()
        {


        }
        */
    }
}
