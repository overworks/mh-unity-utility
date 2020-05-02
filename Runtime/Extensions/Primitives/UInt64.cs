using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static byte[] GetBytes(this ulong value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}
