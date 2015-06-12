using System;

namespace CeraSumat.Utilities.Validation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class RequiredAttribute : Attribute
    {
        public string ErrorMsg { get; set; }

        public RequiredAttribute(string errorMessage = "Argument require a non-null value")
        {
            ErrorMsg = errorMessage;
        }

    }

    [AttributeUsage(AttributeTargets.Property)]
    public class RangeAttribute : Attribute
    {
        public double Min { get; set; }
        public double Max { get; set; }
        public string ErrorMsg { get; set; }

        public RangeAttribute(int minValue, int maxValue, string errorMessage = "Argument out of range")
        {
            Min = minValue;
            Max = maxValue;
            ErrorMsg = errorMessage;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class DataTypeAttribute : Attribute
    {
        public DataType DataType { get; set; }
        public string ErrorMsg { get; set; }

        public DataTypeAttribute(DataType type, string errorMessage = "Data type invalid")
        {
            DataType = type;
            ErrorMsg = errorMessage;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; set; }
        public string ErrorMsg { get; set; }

        public MaxLengthAttribute(int length, string errorMessage = "String length longer than threshold")
        {
            Length = length;
            ErrorMsg = errorMessage;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class MinLengthAttribute : Attribute
    {
        public int Length { get; set; }
        public string ErrorMsg { get; set; }

        public MinLengthAttribute(int length, string errorMessage = "String length shorter than the threshold")
        {
            Length = length;
            ErrorMsg = errorMessage;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class GreaterThanAttribute : Attribute
    {
        public double Threshold { get; set; }
        public string ErrorMsg { get; set; }

        public GreaterThanAttribute(double threshold, string errorMessage = "Argument must greater than the threshold")
        {
            Threshold = threshold;
            ErrorMsg = errorMessage;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class LessThanAttribute : Attribute
    {
        public double Threshold { get; set; }
        public string ErrorMsg { get; set; }

        public LessThanAttribute(double threshold, string errorMessage = "Argument must less than the threshold")
        {
            Threshold = threshold;
            ErrorMsg = errorMessage;
        }
    }
    [AttributeUsage(AttributeTargets.Property)]
    public class NotEqualAttribute : Attribute
    {
        public double JudgeValue { get; set; }
        public string JudgeStr { get; set; }
        public string ErrorMsg { get; set; }

        public NotEqualAttribute(double judgeValue, string errorMessage = "Argument must not equal to the judge value")
        {
            JudgeValue = judgeValue;
            ErrorMsg = errorMessage;
        }

        public NotEqualAttribute(string judgeStr, string errorMessage = "Argument must not equal to the judge value")
        {
            JudgeStr = judgeStr;
            ErrorMsg = errorMessage;
        }
    }
}
