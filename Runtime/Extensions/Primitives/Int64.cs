using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static long Abs(this long value)
        {
            return Math.Abs(value);
        }

        public static byte[] GetBytes(this long value)
        {
            return BitConverter.GetBytes(value);
        }

        public static int Sign(this long value)
        {
            return Math.Sign(value);
        }
    }
}
