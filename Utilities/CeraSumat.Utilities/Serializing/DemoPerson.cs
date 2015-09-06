using System;
using System.Collections;
using System.Collections.Generic;
using CeraSumat.Utilities.TypeParser;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CeraSumat.Utilities.Serializing
{
    /// <summary>
    /// This class demonstrate the JSON serialization function
    /// 
    /// You can control whether this class should be serialize all properties by default or not
    ///     by using this "MemberSerialization" class property.(default value = MemberSerialization.OptOut)
    /// Incording to your selection of this "MemberSerialization" property,
    ///     you can control any property of this class whether to be serialize or not
    ///     by using this "JsonIgnore" field property that demonstrates this field will not be serialized
    ///     or using this "JsonProperty" field property that demonstrates this field will be serialized. 
    /// The JsonConverter attribute demonstrates that DefaultDateTimeConverter to be the DateTime 
    ///     proterty value serializer, and you can modify this serializer as you wish 
    /// The JsonProperty attribute has the "PropertyName" value that used to alter the serialize key
    /// </summary>
    [JsonObject(MemberSerialization.OptOut)]
    public class Person
    {
        [JsonProperty(PropertyName = "身份证号")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstSpell
        {
            get { return Name.GetFirstSpellOfChinese(); }
            set { FirstSpell = value; }
        }
        public string Sex { get; set; }
        [JsonIgnore]
        public bool IsMarried { get; set; }
        [JsonConverter(typeof(DefaultDateTimeConverter))]
        public DateTime Birthday { get; set; }
        public IList<Person> Children { get; set; }
    }


}
