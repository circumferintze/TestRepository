using System.Collections.Generic;

namespace StringMaxMin
{
    public class StringAnalyzer
    {
        private IWriter writer;
        private IPartition partition;

        public StringAnalyzer(IWriter writer, IPartition partition)
        {
            this.writer = writer;
            this.partition = partition;
        }

        public void Analyze(string input)
        {
            writer.WriteLine("Insert your message");
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
