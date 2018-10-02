using System;

namespace StringMaxMin
{
    public class Program
    {
        public static void Main()
        {
            string s = "Love me xx tender love me true Elvis Presley yyyyyyy";
            var writer = new ConsoleWriter();
            var partition = new Partition(s);
            var analyzer = new StringAnalyzer(writer, partition);
            analyzer.Analyze(s);
            Console.ReadKey();
        }
    }
}
