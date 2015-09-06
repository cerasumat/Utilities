using System;

namespace CeraSumat.Utilities.TypeParser
{
    public static class DecimalParser
    {
        public static decimal ToDecimal(this Object srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this string srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue, out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this int srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this short srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this long srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this float srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0m;
        }

        public static decimal ToDecimal(this double srcValue)
        {
            decimal targetValue;
            return Decimal.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0m;
        }
    }
}
