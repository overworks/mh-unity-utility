using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static float Abs(this float value)
        {
            return Math.Abs(value);
        }

        public static byte[] GetBytes(this float value)
        {
            return BitConverter.GetBytes(value);
        }

        public static int Sign(this float value)
        {
            return Math.Sign(value);
        }
    }
}
