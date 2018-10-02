using Xunit;

namespace StringMaxMin.Tests
{
    public class PartitionTests
    {
        [Fact]
        public void ReturnWordsWithMinimumLength_Returns_Words_With_Minimum_Length()
        {
            Partition str = new Partition("MKhkjh v jgjg hfjfffj");
            var expected = new[] { "v" };
            var actual = str.GetShortestWords();

            Assert.Equal(expected, actual);
        }
    }
}
