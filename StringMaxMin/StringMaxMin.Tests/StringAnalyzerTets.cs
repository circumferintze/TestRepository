using System.Collections.Generic;
using Xunit;

namespace StringMaxMin.Tests
{
    public class StringAnalyzerTets
    {
        [Fact]
        public void Analyze_Should_Show_Message()
        {
            var writer = new MemoryWriter();
            var partition = new TestPartition();
            var analyzer = new StringAnalyzer(writer, partition);
            var expected = @"Insert your message
Words with minimum length: B
Words with maximum length: aaaa
";

            analyzer.Analyze("The quick brown fox jumps over the lazy dog.");
            var actual = writer.GetValue();

            Assert.Equal(expected, actual);
        }
    }

    internal class TestPartition : IPartition
    {
        public IEnumerable<string> GetLongestWords()
        {
            return new[] { "aaaa"};
        }

        public IEnumerable<string> GetShortestWords()
        {
            return new[] { "B" };
        }
    }
}
