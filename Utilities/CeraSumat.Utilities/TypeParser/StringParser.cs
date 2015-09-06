using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CeraSumat.Utilities.TypeParser
{
    public static class StringParser
    {
        public static string GetFirstSpellOfChinese(this string word, string mode = "u")
        {
            if (string.IsNullOrEmpty(word)) return string.Empty;
            var length = word.Length;
            var sb = new StringBuilder();
            for (var i = 0; i < length; i++)
            {
                var wordChar = word.Substring(i, 1);
                sb.Append(IsChinese(wordChar) ? GetSpell(wordChar) : wordChar);
            }
            return mode.ToLower() == "u" ? sb.ToString().ToUpper() : sb.ToString().ToLower();
        }

        private static bool IsChinese(string word)
        {
            return Regex.IsMatch(word, @"^[\u4E00-\u9FA5]+$");
        }

        /// <summary>  
        /// 获取单个汉字的首拼音  
        /// </summary>  
        /// <param name="myChar">需要转换的字符</param>  
        /// <returns>转换结果</returns>  
        private static string GetSpell(string myChar)
        {
            var arrCN = Encoding.Default.GetBytes(myChar);
            if (arrCN.Length > 1)
            {
                var area = (short)arrCN[0];
                var pos = (short)arrCN[1];
                var code = (area << 8) + pos;
                int[] areacode = { 45217, 45253, 45761, 46318, 46826, 47010, 47297, 47614, 48119, 48119, 49062, 49324, 49896, 50371, 50614, 50622, 50906, 51387, 51446, 52218, 52698, 52698, 52698, 52980, 53689, 54481 };
                for (var i = 0; i < 26; i++)
                {
                    var max = 55290;
                    if (i != 25) max = areacode[i + 1];
                    if (areacode[i] <= code && code < max)
                    {
                        return Encoding.Default.GetString(new byte[] { (byte)(65 + i) });
                    }
                }
                return "_";
            }
            return myChar;
        }
    }
}
