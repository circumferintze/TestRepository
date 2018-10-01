using System.Collections.Generic;

namespace StringMaxMin
{
    public interface IPartition
    {
        IEnumerable<string> GetLongestWords();
        IEnumerable<string> GetShortestWords();
    }
}