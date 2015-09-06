using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeraSumat.Utilities.TypeParser
{
    public static class SingleParser
    {
        public static float ToSingle(this Object srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this string srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue, out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this short srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this int srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this long srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString(), out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this decimal srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0f;
        }

        public static float ToSingle(this double srcValue)
        {
            float targetValue;
            return Single.TryParse(srcValue.ToString("N"), out targetValue) ? targetValue : 0f;
        }
    }
}
