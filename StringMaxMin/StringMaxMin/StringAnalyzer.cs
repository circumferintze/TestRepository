using System.Collections.Generic;

namespace StringMaxMin
{
    internal class StringAnalyzer
    {
        private IWriter writer;
        private PartitionFactory partitionFactory;
        private readonly IStringProvider stringProvider;

        public StringAnalyzer(IWriter writer, PartitionFactory partition, IStringProvider stringProvider)
        {
            this.writer = writer;
            this.partitionFactory = partition;
            this.stringProvider = stringProvider;
        }

        public void Analyze()
        {
            var partition = partitionFactory.GetPartition(stringProvider);
            var minWords = partition.GetShortestWords();
            var maxWords = partition.GetLongestWords();
            writer.Write($"Words with minimum length: ");
            PrintCollection(minWords);
            writer.Write($"Words with maximum length: ");
            PrintCollection(maxWords);
        }

        public void PrintCollection(IEnumerable<string> a)
        {
            writer.WriteLine(string.Join(" ", a));
        }
    }
}
