using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNull()
        {
            // Arrange 
            string input = null;

            // Act
            var remover = new Remover();
            string expected = remover.Remove(input);

            // Assert
            Assert.IsNull(expected);
        }

        [TestMethod]
        public void TestWithoutDuplicates()
        {
            // Arrange 
            string input = "abcd";
            string expected = "abcd";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithAllDuplicates()
        {
            // Arrange 
            string input = "aaa";
            string expected = "a";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWithNonContiniousDuplicates()
        {
            // Arrange 
            string input = "abababa";
            string expected = "ab";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDuplicatesAtTheBegining()
        {
            // Arrange 
            string input = "aabcd";
            string expected = "abcd";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDuplicatesAtTheEnd()
        {
            // Arrange 
            string input = "abcdd";
            string expected = "abcd";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestDuplicatesAtTheMiddle()
        {
            // Arrange 
            string input = "abbccd";
            string expected = "abcd";

            // Act
            var remover = new Remover();
            string actual = remover.Remove(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
