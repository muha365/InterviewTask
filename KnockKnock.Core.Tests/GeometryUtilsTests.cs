using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace KnockKnock.Core.Tests
{
    public class GeometryUtilsTests
    {

        [InlineData(60, 60, 60, TriangleType.Equilateral)]
        [InlineData(208, 208, 168, TriangleType.Isosceles)]
        [InlineData(30, 120, 30, TriangleType.Error)]
        [InlineData(0, 0, 0, TriangleType.Error)]
        [InlineData(0, 110, 20, TriangleType.Error)]
        [InlineData(50, 50, 50, TriangleType.Equilateral)]
        [InlineData(-1, -1, -50, TriangleType.Error)]
        [InlineData(90, 110, 50, TriangleType.Scalene)]
        [Theory]
        public void GetTriangleType(int a, int b, int c, TriangleType expected)
        {
            var actual = GeometryUtils.GetTriangleName(a, b, c);
            Assert.Equal(expected, actual); 
        }


    }

}
