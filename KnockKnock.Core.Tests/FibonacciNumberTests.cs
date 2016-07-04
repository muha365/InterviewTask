using System;
using Xunit;

namespace KnockKnock.Core.Tests
{
    public class FibonacciNumberTests
    {
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(5, 5)]
        [InlineData(-5, -5)]
        [InlineData(-6, -8)]
        [InlineData(20, 6765)]
        [InlineData(-20, -6765)]
        [InlineData(88, 1100087778366101931)]
        [InlineData(-88, -1100087778366101931)]
        [Theory]
        public void ShouldReturnFibonacciNumber(long input, long expected)
        {
            long actual = input.Fib();
            Assert.Equal<long>(expected, actual);
        }
         
        [Fact]
        public void ShouldThrowOutOfRangeExceptionValueGreaterThan92()
        {
            long input = 93;
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => input.Fib());
            Assert.Equal("n", ex.ParamName);
        }

        [Fact]
        public void ShouldThrowOutOfRangeExceptionValueLessThanNegative92()
        {
            long input = -93;
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => input.Fib());
            Assert.Equal("n", ex.ParamName);
        }

    }

}
