using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace UnitTest
{
    public class UnitTestGetMinimumDifference
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            List<string> a = new List<string>()
            {
                "a", "jk", "abb", "mn", "abc"
            };

            List<string> b = new List<string>()
            {
                "bb", "kj", "bbc", "op", "def"
            };

            List<int> expectedList = new List<int> {-1, 0, 1, 2, 3};

            // Act
            List<int> result = ConsoleAppGetMinimumDifference.Result.getMinimumDifference(a, b);

            // Assert
            Assert.Equal(expectedList, result);
        }

        [Fact]
        public void TestMethod2()
        {
            // Arrange
            List<string> a = new List<string>()
            {
                "ab"
            };

            List<string> b = new List<string>()
            {
                "bc"
            };

            List<int> expectedList = new List<int> { 1};

            // Act
            List<int> result = ConsoleAppGetMinimumDifference.Result.getMinimumDifference(a, b);

            // Assert
            Assert.Equal(expectedList, result);
        }

        [Fact]
        public void TestMethod3()
        {
            // Arrange
            List<string> a = new List<string>()
            {
                "abc", "aaa"
            };

            List<string> b = new List<string>()
            {
                "bba", "bbb"
            };

            List<int> expectedList = new List<int> { 1, 3 };

            // Act
            List<int> result = ConsoleAppGetMinimumDifference.Result.getMinimumDifference(a, b);

            // Assert
            Assert.Equal(expectedList, result);
        }


    }
}
