using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace KnockKnock.Core
{
    [DataContractAttribute(Name = "TriangleType", Namespace = "http://KnockKnock.readify.net")]
    public enum TriangleType : int
    {

        [EnumMemberAttribute()]
        Error = 0,

        [EnumMemberAttribute()]
        Equilateral = 1,

        [EnumMemberAttribute()]
        Isosceles = 2,

        [EnumMemberAttribute()]
        Scalene = 3,
    }
}
