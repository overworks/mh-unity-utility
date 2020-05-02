using System;

namespace Mh
{
    public static partial class PrimitiveExtensions
    {
        public static byte[] GetBytes(this char value)
        {
            return BitConverter.GetBytes(value);
        }
    }
}
