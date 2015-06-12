using System;

namespace CeraSumat.Utilities.Parser
{
    public static class DoubleParser
    {
        public static short ToInt16(this double x)
        {
            return (short)x;
        }

        public static ushort ToUInt16(this double x)
        {
            if (x > 0) return (ushort)x;
            throw new ArgumentException("Negative value could not be parsed to UInt16");
        }
        public static int ToInt32(this double x)
        {
            return (int)x;
        }
        public static uint ToUInt32(this double x)
        {
            if (x > 0) return (uint)x;
            throw new ArgumentException("Negative value could not be parsed to UInt32");
        }
        public static long ToInt64(this double x)
        {
            return (long)x;
        }
        public static ulong ToUInt64(this double x)
        {
            if (x > 0) return (ulong)x;
            throw new ArgumentException("Negative value could not be parsed to UInt64");
        }
        public static decimal ToDecimal(this double x)
        {
            return (decimal)x;
        }
        public static float ToFloat(this double x)
        {
            return (float)x;
        }
    }
}
