using System;

namespace CeraSumat.Utilities.Parser
{
    public static class LongParser
    {
        public static short ToInt16(this long x)
        {
            return (short)x;
        }

        public static ushort ToUInt16(this long x)
        {
            if (x > 0) return (ushort)x;
            throw new ArgumentException("Negative value could not be parsed to UInt16");
        }

        public static int ToInt32(this long x)
        {
            return (int)x;
        }

        public static uint ToUInt32(this long x)
        {
            if (x > 0) return (uint)x;
            throw new ArgumentException("Negative value could not be parsed to UInt32");
        }

        public static decimal ToDecimal(this long x)
        {
            return (decimal)x;
        }
        public static float ToFloat(this long x)
        {
            return (float)x;
        }
        public static double ToDouble(this long x)
        {
            return (double)x;
        }
    }
}
