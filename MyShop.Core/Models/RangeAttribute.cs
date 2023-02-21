using System;

namespace MyShop.Core.Models
{
    public class RangeAttribute : Attribute
    {
        public RangeAttribute(int v1, int v2)
        {
            V1 = v1;
            V2 = v2;
        }

        public int V1 { get; }
        public int V2 { get; }
    }
}