using Xunit;

namespace UnitTest
{

    public class UnitTestLongestEvenWord
    {
        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var inputMessage = "It is a pleasant day today";

            // Act
            var result = ConsoleAppLongestEvenWord.Result.longestEvenWord(inputMessage);

            // Assert
            Assert.Equal("pleasant", result);

        }

        [Fact]
        public void TestMethod2()
        {
            // Arrange
            var inputMessage = "You can do it the way you like";

            // Act
            var result = ConsoleAppLongestEvenWord.Result.longestEvenWord(inputMessage);

            // Assert
            Assert.Equal("like", result);

        }

        [Fact]
        public void TestMethod3()
        {
            // Arrange
            var inputMessage = "hey";

            // Act
            var result = ConsoleAppLongestEvenWord.Result.longestEvenWord(inputMessage);

            // Assert
            Assert.Equal("00", result);

        }

    }
}
