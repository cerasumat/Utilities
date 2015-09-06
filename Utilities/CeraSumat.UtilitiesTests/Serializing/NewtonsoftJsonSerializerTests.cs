using Microsoft.VisualStudio.TestTools.UnitTesting;
using CeraSumat.Utilities.Serializing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeraSumat.Utilities.TypeParser;

namespace CeraSumat.Utilities.Serializing.Tests
{
    [TestClass()]
    public class NewtonsoftJsonSerializerTests
    {
        [TestMethod()]
        public void SerializeTest()
        {
            var jiakai = new Person
            {
                Id = 1,
                Name = "贾凯",
                Sex = "male",
                IsMarried = false,
                Birthday = new DateTime(1981, 10, 17),
                Children = new List<Person>
                {
                    new Person {Id = 2, Name = "jk", Sex = "male", Birthday = new DateTime(2000, 10, 17)},
                    new Person {Id = 3, Name = "jiak", Sex = "male", Birthday = new DateTime(2001, 11, 17)}
                }
            };
            var serializer = new NewtonsoftJsonSerializer();
            var jsonObj = serializer.Serialize(jiakai);


            Assert.IsTrue(jsonObj.Length>0);
        }

        [TestMethod()]
        public void DeserializeTest()
        {
            var nowMilSecs = DateTime.Now.Ticks;
            var nowStr = new DateTime(nowMilSecs, DateTimeKind.Utc).ToString("yyyy-MM-dd HH:mm:ss");

            var strObj = "{'Id':1,'Name':'jiakai','Sex':'male','IsMarried':false,'Birthday':'" +
                         nowStr + "'}";
            var listObj =
                "{ '身份证号':1,'Name':'jiakai','Sex':'male','Birthday':'1981-10-17 00:00:00','Children':[{'身份证号':2,'Name':'jk','Sex':'male','Birthday':'2000-10-17 00:00:00','Children':null},{'身份证号':3,'Name':'jiak','Sex':'male','Birthday':'2001-11-17 00:00:00','Children':null}]}";
            var serializer = new NewtonsoftJsonSerializer();
            var person = serializer.Deserialize<Person>(strObj);
            var personWithChildren = serializer.Deserialize<Person>(listObj);
            
            Assert.IsNotNull(person);
            Assert.IsNotNull(personWithChildren);
        }
    }
}