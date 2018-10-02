using System;
using System.Linq;

namespace StringMaxMin
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            StringAnalyzer analyzer;
            var writer = new ConsoleWriter();
            var partition = new PartitionFactory();
            if (!args.Any())
            {
                var consoleProvider = new ConsoleValueReader();
                consoleProvider.ReadLine();
                analyzer = new StringAnalyzer(writer, partition, consoleProvider);
            }
            else
            {
                var fileValueReader = new FileValueReader();
                fileValueReader.ReadFile(args[0]);
                analyzer = new StringAnalyzer(writer, partition, fileValueReader);
            }
            analyzer.Analyze();
            Console.ReadKey();
        }
    }
}
