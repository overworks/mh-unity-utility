using System;

namespace Mh
{
    public static partial class PrimitiveExtensions
    {
        public static sbyte Abs(this sbyte value)
        {
            return Math.Abs(value);
        }

        public static int Sign(this sbyte value)
        {
            return Math.Sign(value);
        }
    }
}
