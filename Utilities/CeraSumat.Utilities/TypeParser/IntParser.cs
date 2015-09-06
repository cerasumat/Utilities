using System;

namespace CeraSumat.Utilities.TypeParser
{
    public static class IntParser
    {
        public static int ToInt32(this Object srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this string srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue, out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this short srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this long srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this float srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this decimal srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0;
        }

        public static int ToInt32(this double srcValue)
        {
            int targetValue;
            return Int32.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0;
        }
    }
}
