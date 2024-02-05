using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("will", false)]
        [InlineData("anna", true)]
        [InlineData("toy", false)]
        [InlineData("madam", true)]
        [InlineData("level", true)]
        [InlineData("deified", true)]
        [InlineData("rotor", true)]
        [InlineData("California", false)]
        [InlineData("California where", false)]


        // ? you will need to put some test data and expected result here.  

        // For example [InlineData(“racecar”, true)]
        public void Test1(string wString, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(wString);

            //Assert
            Assert.Equal(expected, actual);


        }
    }
}
