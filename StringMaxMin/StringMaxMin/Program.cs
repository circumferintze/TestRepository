using System;

namespace StringMaxMin
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            Console.WriteLine("Insert your message");
            //string s = Console.ReadLine();
            string s = "! a kjkhfks , hhf";
            Partition partition = new Partition(s);
            partition.PartitionOfString();
            Console.ReadKey();
        }
    }

    
}
