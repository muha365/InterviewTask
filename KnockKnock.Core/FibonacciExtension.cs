using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock.Core
{
    public static class FibonacciExtension
    {
        static ConcurrentDictionary<int, long> cache = new ConcurrentDictionary<int, long>(100,95);
        public static long Fib(this long n)
        {
            if (n > 92 || n < -92)
            {
                throw new ArgumentOutOfRangeException(nameof(n),
                    "Fib(>92) will cause a 64-bit integer overflow");
            }
            long result = CalculateFibonacci((int)Math.Abs(n));
            if (n < 0)
                result = result * -1;
            
             return result;
        }
        private static long CalculateFibonacci(int n)
        {
            if (n == 0) return cache.GetOrAdd(0, 0);
            if (n == 1) return cache.GetOrAdd(1, 1);

            return cache.GetOrAdd(n,(a)=> CalculateFibonacci(a - 1) + CalculateFibonacci(a - 2));
        }
    }
}
