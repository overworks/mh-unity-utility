using System;

namespace Mh
{
    public static partial class PrimitiveExtensions
    {
        public static bool ToBoolean(this byte[] value, int startIndex)
        {
            return BitConverter.ToBoolean(value, startIndex);
        }

        public static char ToChar(this byte[] value, int startIndex)
        {
            return BitConverter.ToChar(value, startIndex);
        }

        public static short ToInt16(this byte[] value, int startIndex)
        {
            return BitConverter.ToInt16(value, startIndex);
        }

        public static ushort ToUInt16(this byte[] value, int startIndex)
        {
            return BitConverter.ToUInt16(value, startIndex);
        }

        public static int ToInt32(this byte[] value, int startIndex)
        {
            return BitConverter.ToInt32(value, startIndex);
        }

        public static uint ToUInt32(this byte[] value, int startIndex)
        {
            return BitConverter.ToUInt32(value, startIndex);
        }

        public static long ToInt64(this byte[] value, int startIndex)
        {
            return BitConverter.ToInt64(value, startIndex);
        }

        public static ulong ToUInt64(this byte[] value, int startIndex)
        {
            return BitConverter.ToUInt64(value, startIndex);
        }

        public static float ToSingle(this byte[] value, int startIndex)
        {
            return BitConverter.ToSingle(value, startIndex);
        }

        public static double ToDouble(this byte[] value, int startIndex)
        {
            return BitConverter.ToDouble(value, startIndex);
        }

        public static string ToString(this byte[] value)
        {
            return BitConverter.ToString(value);
        }

        public static string ToString(this byte[] value, int startIndex)
        {
            return BitConverter.ToString(value, startIndex);
        }

        public static string ToString(this byte[] value, int startIndex, int length)
        {
            return BitConverter.ToString(value, startIndex, length);
        }
    }
}
