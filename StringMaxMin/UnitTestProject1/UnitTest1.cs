using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringMaxMin;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnWordsWithMinimumLengthTest()
        {
            Partition str = new Partition();
            var actual = str.ReturnWordsWithMinimumLength();
            CollectionAssert.AreEqual()
        }
    }
}
