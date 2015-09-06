using System;

namespace CeraSumat.Utilities.TypeParser
{
    public static class LongParser
    {
        public static long ToInt64(this Object srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this string srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue, out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this short srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this int srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this float srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this decimal srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0L;
        }

        public static long ToInt64(this double srcValue)
        {
            long targetValue;
            return Int64.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0L;
        }
    }
}
