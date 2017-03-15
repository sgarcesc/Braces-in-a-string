using System;
using Xunit;
using Braces;

namespace Braces.UnitTest
{
    public class ProgramTests
    {
        [Fact]
        public void TestCase0()
        {
            //Arrange
            var expected = "YES";

            //Act
            var result = Program.IsMatch("{}[]()");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase1()
        {
            //Arrange
            var expected = "NO";

            //Act
            var result = Program.IsMatch("{[}]");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase2()
        {
            //Arrange
            var expected = "NO";

            //Act
            var result = Program.IsMatch("{[()}]");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase3()
        {
            //Arrange
            var expected = "YES";

            //Act
            var result = Program.IsMatch("[{()()}({[]})]({}[({})])((((((()[])){}))[]{{{({({({{{{{{}}}}}})})})}}}))[][][]");

            //Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestCase4()
        {
            var expected = "YES";

            //Act
            var result = Program.IsMatch("{}[]()");

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
