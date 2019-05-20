using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var inputMessage = "It is a pleasant day today";

            // Act
            var result = ConsoleAppLongestEvenWord.Result.longestEvenWord(inputMessage);

            // Assert
            Assert.AreEqual("pleasant", result);

        }
    }
}
