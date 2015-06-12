using System;

namespace CeraSumat.Utilities.Parser
{
    public static class DecimalParser
    {
        public static short ToInt16(this decimal x)
        {
            return (short)x;
        }
        public static ushort ToUInt16(this decimal x)
        {
            if (x > 0) return (ushort)x;
            throw new ArgumentException("Negative value could not be parsed to UInt16");
        }
        public static int ToInt32(this decimal x)
        {
            return (int)x;
        }
        public static uint ToUInt32(this decimal x)
        {
            if (x > 0) return (uint)x;
            throw new ArgumentException("Negative value could not be parsed to UInt32");
        }
        public static long ToInt64(this decimal x)
        {
            return (long)x;
        }
        public static ulong ToUInt64(this decimal x)
        {
            if (x > 0) return (ulong)x;
            throw new ArgumentException("Negative value could not be parsed to UInt64");
        }
        public static float ToFloat(this decimal x)
        {
            return (float)x;
        }
        public static double ToDouble(this decimal x)
        {
            return (double)x;
        }
    }
}
