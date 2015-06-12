using System;

namespace CeraSumat.Utilities.Parser
{
    public static class StringParser
    {
        public static short ToInt16(this string str)
        {
            short x;
            var result = short.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Int16");
        }
        public static ushort ToUInt16(this string str)
        {
            ushort x;
            var result = ushort.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to UInt16");
        }
        public static int ToInt32(this string str)
        {
            int x;
            var result = int.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Int32");
        }
        public static uint ToUInt32(this string str)
        {
            uint x;
            var result = uint.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to UInt32");
        }
        public static long ToInt64(this string str)
        {
            long x;
            var result = long.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Int64");
        }
        public static ulong ToUInt64(this string str)
        {
            ulong x;
            var result = ulong.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to UInt64");
        }
        public static decimal ToDecimal(this string str)
        {
            decimal x;
            var result = decimal.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Decimal");
        }
        public static float ToFloat(this string str)
        {
            float x;
            var result = float.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Float");
        }
        public static double ToDouble(this string str)
        {
            double x;
            var result = double.TryParse(str, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to Double");
        }
        public static DateTime ToDateTime(this string str)
        {
            DateTime x;
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            var result = DateTime.TryParse(str, culture, System.Globalization.DateTimeStyles.AssumeLocal, out x);
            if (result) return x;
            throw new ArgumentException("This string can not parse to DateTime");
        }
    }
}
