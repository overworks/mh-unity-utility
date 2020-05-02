using System;

namespace Mh
{
    public static partial class PrimitiveExtentions
    {
        public static decimal Abs(this decimal value)
        {
            return Math.Abs(value);
        }

        public static decimal Ceiling(this decimal d)
        {
            return Math.Ceiling(d);
        }

        public static decimal Floor(this decimal d)
        {
            return Math.Floor(d);
        }

        public static decimal Round(this decimal d)
        {
            return Math.Round(d);
        }

        public static decimal Round(this decimal d, int decimals)
        {
            return Math.Round(d, decimals);
        }

        public static decimal Round(this decimal d, int decimals, MidpointRounding mode)
        {
            return Math.Round(d, decimals, mode);
        }

        public static decimal Round(this decimal d, MidpointRounding mode)
        {
            return Math.Round(d, mode);
        }

        public static int Sign(this decimal value)
        {
            return Math.Sign(value);
        }
    }
}
