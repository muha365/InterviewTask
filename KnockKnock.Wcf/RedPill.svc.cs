using KnockKnock.Core;
using System;
using System.Runtime.Caching;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace KnockKnock.Wcf
{
    [ServiceBehavior(
        Namespace = "http://KnockKnock.readify.net",
        IncludeExceptionDetailInFaults = false,
        InstanceContextMode = InstanceContextMode.Single,
        ConcurrencyMode = ConcurrencyMode.Multiple)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class RedPill : IRedPill
    {
        public RedPill()
        {
        }

        public long FibonacciNumber(long n)
        {
            return n.Fib();
        }

        public string ReverseWords(string s)
        {
            var key = string.Format("RedPill-RW-{0}", s.GetHashCode());
            var cacheItem = MemoryCache.Default.GetCacheItem(key);
            string result = string.Empty;

            if (cacheItem != null)
            {
                result = (string)cacheItem.Value;
            }
            else
            {
                result = s.ReverseString();
                MemoryCache.Default.Add(new CacheItem(key, result), new CacheItemPolicy() { SlidingExpiration = TimeSpan.FromMinutes(60) });
            }
            return result; 
        }

        public Guid WhatIsYourToken()
        {
            return new Guid("555f5c57-62be-4e9b-93b8-4e6134458c77");
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            return GeometryUtils.GetTriangleName(a, b, c);
        }
    }
}
