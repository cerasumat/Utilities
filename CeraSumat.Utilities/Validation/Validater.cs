using System;
using System.Linq;
using CeraSumat.Utilities.TypeParser;

namespace CeraSumat.Utilities.Validation
{
    public static class Validater
    {
        public static void Validate<T>(this T obj) where T : class 
        {
            var type = obj.GetType();
            var props = type.GetProperties();
            foreach (var prop in props)
            {
                var propType = prop.PropertyType;
                var propValue = prop.GetValue(obj);
                var attrs = prop.GetCustomAttributes(false);
                if (!attrs.Any()) continue;
                foreach (var attr in attrs)
                {
                    var attrType = attr.GetType();
                    var attrProps = attrType.GetProperties();
                    var erroMsg = attrProps.First(a => a.Name == "ErrorMsg").GetValue(attr).ToString();
                    switch (attrType.Name)
                    {
                        case "RequiredAttribute":
                        {
                            if (propType.IsValueType && (decimal) propValue == 0m)
                                throw new ArgumentException(erroMsg, prop.Name);
                            if (propType.IsClass && string.IsNullOrEmpty(propValue?.ToString()))
                                throw new ArgumentNullException(prop.Name, erroMsg);
                        }
                            break;
                        case "RangeAttribute":
                        {
                            if (propType.IsValueType)
                            {
                                var min = attrProps.First(a => a.Name == "Min").GetValue(attr).ToDouble();
                                var max = attrProps.First(a => a.Name == "Max").GetValue(attr).ToDouble();
                                var propValueD = propValue.ToDouble();
                                if (propValueD < min || propValueD > max)
                                    throw new ArgumentOutOfRangeException(prop.Name, erroMsg);
                            }
                        }
                            break;
                        case "DataTypeAttribute":
                        {
                            //var dataType = (DataType)attrProps.First(a => a.Name == "DataType").GetValue(attr);
                        }
                            break;
                        case "MaxLengthAttribute":
                        {
                            if (propType.Name == "String")
                            {
                                var length = attrProps.First(a => a.Name == "Length").GetValue(attr).ToInt32();
                                if (propValue.ToString().Length > length)
                                    throw new ArgumentOutOfRangeException(prop.Name, erroMsg);
                            }
                        }
                            break;
                        case "MinLengthAttribute":
                        {
                            if (propType.Name == "String")
                            {
                                var length = attrProps.First(a => a.Name == "Length").GetValue(attr).ToInt32();
                                if (propValue.ToString().Length < length)
                                    throw new ArgumentOutOfRangeException(prop.Name, erroMsg);
                            }
                        }
                            break;
                        case "GreaterThanAttribute":
                        {
                            if (propType.IsValueType)
                            {
                                var threshold = attrProps.First(a => a.Name == "Threshold").GetValue(attr).ToDouble();
                                var propValueD = propValue.ToDouble();
                                if (propValueD <= threshold)
                                    throw new ArgumentOutOfRangeException(prop.Name, erroMsg);
                            }
                        }
                            break;
                        case "LessThanAttribute":
                        {
                            if (propType.IsValueType)
                            {
                                var threshold = attrProps.First(a => a.Name == "Threshold").GetValue(attr).ToDouble();
                                var propValueD = propValue.ToDouble();
                                if (propValueD >= threshold)
                                    throw new ArgumentOutOfRangeException(prop.Name, erroMsg);
                            }
                        }
                            break;
                        case "NotEqualAttribute":
                        {
                            if (propType.IsValueType)
                            {
                                var judgeValue = attrProps.First(a => a.Name == "JudgeValue").GetValue(attr).ToDouble();
                                var propValueD = propValue.ToDouble();
                                if (propValueD == judgeValue)
                                    throw new ArgumentException(prop.Name, erroMsg);
                            }
                            if (propType.Name == "String")
                            {
                                var judgeStr = attrProps.First(a => a.Name == "JudgeStr").GetValue(attr).ToString();
                                if (propValue.ToString() == judgeStr)
                                    throw new ArgumentException(prop.Name, erroMsg);
                            }
                        }
                            break;
                    }
                }
            }

        }
    }
}
