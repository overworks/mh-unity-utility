using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static short Abs(this short value)
        {
            return Math.Abs(value);
        }

        public static byte[] GetBytes(this short value)
        {
            return BitConverter.GetBytes(value);
        }

        public static int Sign(this short value)
        {
            return Math.Sign(value);
        }

        
    }
}
