using System;

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
            partition.PartitionOfString();
            
            Console.ReadKey();
        }
    }

    
}
