using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static double Abs(this double value)
        {
            return Math.Abs(value);
        }
        
        public static double Ceiling(this double d)
        {
            return Math.Ceiling(d);
        }

        public static double Floor(this double d)
        {
            return Math.Floor(d);
        }

        public static byte[] GetBytes(this double value)
        {
            return BitConverter.GetBytes(value);
        }

        public static double Round(this double d)
        {
            return Math.Round(d);
        }

        public static double Round(this double d, int decimals)
        {
            return Math.Round(d, decimals);
        }

        public static double Round(this double d, int decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }

        public static double Round(this double d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        public static int Sign(this double value)
        {
            return Math.Sign(value);
        }
    }
}
