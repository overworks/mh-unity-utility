using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {

        public static byte[] GetBytes(this uint value)
        {
            return BitConverter.GetBytes(value);
        }

        public static bool IsEven(this uint value)
        {
            return value % 2 == 0;
        }

        public static bool IsOdd(this uint value)
        {
            return value % 2 != 0;
        }
    }
}
