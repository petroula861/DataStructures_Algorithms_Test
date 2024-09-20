using Petras.HashTable;
using Petras.StringManipulations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.StringManipulations
{
    [TestFixture]
    public class IsUniqueChar_Tests
    {
        //[Test]
        public void IsUniqueAllChar()
        {
            // Arrange
            IsUniqueChar c= new IsUniqueChar();

            // Assert
            Assert.IsTrue(c.isAllUnique("avbdfg"));

            Assert.IsFalse(c.isAllUnique("asdfghh"));
        }


    }

    public class FirstUniqueChar_Tests
    {
        [Test]
        public void FirstUniqueChar()
        {
            // Arrange
            IsUniqueChar c = new IsUniqueChar();

            // Assert
            Assert.AreEqual(c.FirstUniqChar("leetcode"),0);

            Assert.AreEqual(c.FirstUniqChar("loveleeltcode"), 2);

            Assert.AreEqual(c.FirstUniqChar("aabb"), -1);
            Assert.AreEqual(c.FirstUniqChar2("aaab"), 3);

        }

    }
}
