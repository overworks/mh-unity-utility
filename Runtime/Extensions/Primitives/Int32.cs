using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static int Abs(this int value)
        {
            return Math.Abs(value);
        }

        public static int Sign(this int value)
        {
            return Math.Sign(value);
        }

        public static byte[] GetBytes(this int value)
        {
            return BitConverter.GetBytes(value);
        }

        public static bool IsEven(this int value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this int value)
        {
            return value % 2 != 0;
        }
    }
}
