using System;
using System.Collections;
using System.Collections.Generic;

namespace StringMaxMin
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert your message");
            //string s = Console.ReadLine();
            string s = "Love me xx tender love me true Elvis Presley yyyyyyy";
            Partition partition = new Partition(s);
            List<string> minWords = partition.ReturnWordsWithMinimumLength();
            List<string> maxWords = partition.ReturnWordsWithMaximumLength();
            Console.Write($"Words with minimum length :");
            minWords.PrintCollection();
            Console.Write($"Words with maximum length :");
            maxWords.PrintCollection();
            Console.ReadKey();
        }
    }

    
}
