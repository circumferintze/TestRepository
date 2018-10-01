using System;

namespace StringMaxMin
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert your message");
            //string s = Console.ReadLine();
            string s = "Love me tender love me true Elvis Presley";
            Partition partition = new Partition(s);
            partition.PartitionOfString();
            Console.ReadKey();
        }
    }

    
}
