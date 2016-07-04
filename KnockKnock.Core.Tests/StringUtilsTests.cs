using KnockKnock.Core;
using System;
using Xunit;

namespace KnockKnock.Core.Tests
{
    public class StringUtilsTests
    {

        [InlineData(" H E L L O W O R L D ", " H E L L O W O R L D ")]
        [InlineData("", "")]
        [InlineData("¿Qué?", "?éuQ¿")]
        [InlineData(@"Hello World! 3435d %$%#"". <hioph>     xyz  
                ", @"olleH !dlroW d5343 .""#%$% >hpoih<     zyx  
                ")]
        [Theory]
        public void ShouldReturnReversedString(string input, string expected)
        {
            var output = input.ReverseString();
            Assert.Equal(expected, output);

        }

        [Fact]
        public void ShouldThrowExceptionWhenStringIsNull()
        {
            string input = null;
            var ex = Assert.Throws<ArgumentNullException>(() => input.ReverseString());
        }

        [Theory]
        [InlineData(@"\r")]
        [InlineData(@"\x20ac")]
        [InlineData(@"\f sdsds")]
        [InlineData(@"Hello \v")]
        public void ShouldThrowExceptionWhenStringContainsSpecialChars(string input)
        {
            var ex = Assert.Throws<ArgumentNullException>(() => input.ReverseString());
            Assert.Equal("s", ex.ParamName);
        }

    }

}
