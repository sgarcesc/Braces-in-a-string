using System;
using Xunit;
using Braces;

namespace Braces.UnitTest
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("{}[]()")]
        [InlineData("[{()()}({[]})]({}[({})])((((((()[])){}))[]{{{({({({{{{{{}}}}}})})})}}}))[][][]")]
        [InlineData("{}[]()")]
        public void IsMatchReturnsYes(string value)
        {
            //Arrange
            var expected = "YES";

            //Act
            var result = Program.IsMatch(value);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("{[}]")]
        [InlineData("{[()}]")]
        public void IsMatchReturnsNo(string value)
        {
            //Arrange
            var expected = "NO";

            //Act
            var result = Program.IsMatch(value);

            //Assert
            Assert.Equal(expected, result);
        }
    }
}
