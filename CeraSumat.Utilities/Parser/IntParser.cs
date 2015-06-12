using System;

namespace CeraSumat.Utilities.Parser
{
    public static class IntParser
    {
        public static short ToInt16(this int x)
        {
            return (short) x;
        }

        public static ushort ToUInt16(this int x)
        {
            if (x > 0) return (ushort) x;
            throw new ArgumentException("Negative value could not be parsed to UInt16");
        }

        public static long ToInt64(this int x)
        {
            return (long) x;
        }

        public static ulong ToUInt64(this int x)
        {
            if (x > 0) return (ulong) x;
            throw new ArgumentException("Negative value could not be parsed to UInt64");
        }

        public static decimal ToDecimal(this int x)
        {
            return (decimal) x;
        }
        public static float ToFloat(this int x)
        {
            return (float) x;
        }
        public static double ToDouble(this int x)
        {
            return (double) x;
        }
    }
}
