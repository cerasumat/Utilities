using System;

namespace CeraSumat.Utilities.Parser
{
    public static class ObjectParser
    {
        public static short ToInt16(this object obj)
        {
            short x;
            var result = short.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Int16");
        }
        public static ushort ToUInt16(this object obj)
        {
            ushort x;
            var result = ushort.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to UInt16");
        }
        public static int ToInt32(this object obj)
        {
            int x;
            var result = int.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Int32");
        }
        public static uint ToUInt32(this object obj)
        {
            uint x;
            var result = uint.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to UInt32");
        }
        public static long ToInt64(this object obj)
        {
            long x;
            var result = long.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Int64");
        }
        public static ulong ToUInt64(this object obj)
        {
            ulong x;
            var result = ulong.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to UInt64");
        }
        public static decimal ToDecimal(this object obj)
        {
            decimal x;
            var result = decimal.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Decimal");
        }
        public static float ToFloat(this object obj)
        {
            float x;
            var result = float.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Float");
        }
        public static double ToDouble(this object obj)
        {
            double x;
            var result = double.TryParse(obj.ToString(), out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to Double");
        }
        public static DateTime ToDateTime(this object obj)
        {
            DateTime x;
            var culture = System.Globalization.CultureInfo.CurrentCulture;
            var result = DateTime.TryParse(obj.ToString(), culture, System.Globalization.DateTimeStyles.AssumeLocal, out x);
            if (result) return x;
            throw new ArgumentException("This object can not parse to DateTime");
        }
        public static T To<T>(this object obj) where T : class
        {
            var x = obj as T;
            if (x != null) return x;
            var typeName = typeof (T).Name;
            throw new ArgumentException(string.Format("This object can not parse to {0}", typeName));
        }
    }
}
