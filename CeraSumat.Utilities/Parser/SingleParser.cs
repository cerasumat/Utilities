using System;

namespace CeraSumat.Utilities.Parser
{
    public static class SingleParser
    {
        public static short ToInt16(this float x)
        {
            return (short)x;
        }
        public static ushort ToUInt16(this float x)
        {
            if (x > 0) return (ushort)x;
            throw new ArgumentException("Negative value could not be parsed to UInt16");
        }
        public static int ToInt32(this float x)
        {
            return (int)x;
        }
        public static uint ToUInt32(this float x)
        {
            if (x > 0) return (uint)x;
            throw new ArgumentException("Negative value could not be parsed to UInt32");
        }
        public static long ToInt64(this float x)
        {
            return (long)x;
        }
        public static ulong ToUInt64(this float x)
        {
            if (x > 0) return (ulong)x;
            throw new ArgumentException("Negative value could not be parsed to UInt64");
        }
        public static decimal ToDecimal(this float x)
        {
            return (decimal)x;
        }
        public static double ToDouble(this float x)
        {
            return (double)x;
        }
    }
}
