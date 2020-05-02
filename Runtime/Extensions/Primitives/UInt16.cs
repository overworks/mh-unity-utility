using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static byte[] GetBytes(this ushort value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}
