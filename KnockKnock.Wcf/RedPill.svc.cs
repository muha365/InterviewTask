using KnockKnock.Core;
using System;
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
            throw new NotImplementedException();
        }

        public Guid WhatIsYourToken()
        {
            throw new NotImplementedException();
        }

        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            throw new NotImplementedException();
        }
    }
}
