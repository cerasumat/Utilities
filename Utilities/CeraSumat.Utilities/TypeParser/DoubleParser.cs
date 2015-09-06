using System;

namespace CeraSumat.Utilities.TypeParser
{
    public static class DoubleParser
    {
        public static double ToDouble(this Object srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this string srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue, out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this int srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this short srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this long srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this float srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0d;
        }

        public static double ToDouble(this decimal srcValue)
        {
            double targetValue;
            return Double.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0d;
        }
    }
}
