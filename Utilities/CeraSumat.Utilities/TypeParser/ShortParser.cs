using System;

namespace CeraSumat.Utilities.TypeParser
{
    public static class ShortParser
    {
        public static short ToInt16(this Object srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString(), out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this string srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue, out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this int srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString(), out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this long srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString(), out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this float srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this decimal srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : (short)0;
        }

        public static short ToInt16(this double srcValue)
        {
            short targetValue;
            return Int16.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : (short)0;
        }
    }
}
