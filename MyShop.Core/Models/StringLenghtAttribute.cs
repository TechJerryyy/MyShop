using System;

namespace MyShop.Core.Models
{
    public class StringLenghtAttribute : Attribute
    {
        private int v;

        public StringLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}