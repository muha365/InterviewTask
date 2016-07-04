using System;
using System.Collections.Concurrent;
using System.Runtime.Caching;

namespace KnockKnock.Core
{
    public class GeometryUtils
    {
        public static TriangleType GetTriangleName(int a, int b, int c)
        { 
            //Check if it is Triangle
            if ((a <= 0 || b <= 0 || c <= 0) || (!(c + b > a) || !(a + b > c) || !(a + c > b)))
            {
                return TriangleType.Error;
            }
            // get distinct sides count once 
            if (a == b && a == c && b == c)
            {
                return TriangleType.Equilateral;
            }
            if (a == b && a != c && b != c)
            {
                return TriangleType.Isosceles;
            }
            return TriangleType.Scalene;
        }
    }
}