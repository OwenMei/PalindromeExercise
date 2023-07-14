using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("basinab", false)]
        [InlineData("mushsum", true)]
        [InlineData("asdfklwefjnasodfiasdhjiugfh4ewiulhdsakd", false)]
        [InlineData("a", true)]
        public void IsAPalindromeTest(string str, bool expected)
        {
            WordSmith newSmith = new WordSmith();
            bool actual = newSmith.IsAPalindrome(str);
            Assert.Equal(expected, actual);
        }
    }
}
