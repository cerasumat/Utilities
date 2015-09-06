using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeraSumat.Utilities.TypeParser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeraSumat.Utilities.TypeParser.Tests
{
    [TestClass()]
    public class StringParserTests
    {
        [TestMethod()]
        public void GetFirstSpellOfChineseTest()
        {
            var word1 = "";
            var word2 = "123";
            var word3 = "abcd";
            var word4 = "$%^";
            var word5 = "ab12!@";
            var word6 = "贾凯";
            var word7 = "贾a凯12";
            var word8 = "_2贾d凯";
            var spell1 = word1.GetFirstSpellOfChinese("l")=="";
            var spell2 = word2.GetFirstSpellOfChinese("l") =="123";
            var spell3 = word3.GetFirstSpellOfChinese("l") =="abcd";
            var spell4 = word4.GetFirstSpellOfChinese()=="$%^";
            var spell5 = word5.GetFirstSpellOfChinese()=="AB12!@";
            var spell6 = word6.GetFirstSpellOfChinese()=="JK";
            var spell7 = word7.GetFirstSpellOfChinese()=="JAK12";
            var spell8 = word8.GetFirstSpellOfChinese("L") == "_2jdk";
            Assert.IsTrue(spell1 && spell2 && spell3 && spell4 && spell5 && spell6 && spell7 && spell8);
        }
    }
}