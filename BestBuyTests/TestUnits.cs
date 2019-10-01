using System;
using Xunit;
using BestBuy;

namespace BestBuyTests
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("noon", true)]
        [InlineData("hannah", true)]
        [InlineData("wesley", false)]
        [InlineData("truecoders", false)]
        [InlineData("trueeurt", true)]
        [InlineData("yoloy", true)]
        [InlineData("test", false)]
        [InlineData("dog", false)]
        public void IsPalindrome(string isPalindrome, bool expected)
        {
            Palindrome palindrome = new Palindrome();

            var actual = palindrome.IsPalindrome(isPalindrome);

            Assert.Equal(expected, actual);
        }
    }

    public class MyMathTests
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 11, 21)]
        [InlineData(-3.5, 2, -1.5)]
        [InlineData(1.11, 2.22, 3.33)]
        [InlineData(0, 0.000001, 0.000001)]
        [InlineData(-500, -5, -505)]
        [InlineData(-.01, .01, 0)]
        public void SumOfTwoNumbers(double num1, double num2, double expected)
        {
            var actual = MyMath.SumTwoNumbers(num1, num2);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5, 0, 100, 0, 1, .05)]
        [InlineData(1, 0, 100, 0, 1, .01)]
        [InlineData(3, 0, 5, 0, 100, 60)]
        [InlineData(100, 0, 100, 0, 1000, 1000)]
        [InlineData(300, 0, 1000, 0, 10, 3)]
        public void ChangeRange(double value, double oldMin, double oldMax, double newMin, double newMax, double expected)
        {
            var actual = MyMath.MapValue(value, oldMin, oldMax, newMin, newMax);

            Assert.Equal(expected, actual);
        }
    }
}