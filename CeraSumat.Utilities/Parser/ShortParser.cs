using System;

namespace CeraSumat.Utilities.Parser
{
    public static class ShortParser
    {
        public static int ToInt32(this short x)
        {
            return (int)x;
        }

        public static uint ToUInt32(this short x)
        {
            if (x > 0) return (uint)x;
            throw new ArgumentException("Negative value could not be parsed to UInt32");
        }

        public static long ToInt64(this short x)
        {
            return (long)x;
        }

        public static ulong ToUInt64(this short x)
        {
            if (x > 0) return (ulong)x;
            throw new ArgumentException("Negative value could not be parsed to UInt64");
        }

        public static decimal ToDecimal(this short x)
        {
            return (decimal)x;
        }
        public static float ToFloat(this short x)
        {
            return (float)x;
        }
        public static double ToDouble(this short x)
        {
            return (double)x;
        }
    }
}
