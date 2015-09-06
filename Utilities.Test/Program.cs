using System;
using System.Collections.Generic;
using CeraSumat.Utilities.TypeParser;
using CeraSumat.Utilities.Validation;

namespace Utilities.Test
{
    class Program
    {
        public class Student
        {
            [MaxLength(5)]
            [NotEqual("JiaK")]
            public string Name { get; set; }

            [Range(1, 100)]
            [NotEqual(1)]
            [LessThan(3.5)]
            public int Id { get; set; }
        }
        static void Main(string[] args)
        {
            var list = new List<int> {1,2,3,4} as IEnumerable<int>;
            list.ForEach(x => Console.WriteLine(x));
            list=list.ForEach(v => v + 1);

            var s = new Student {Id = 4, Name = "Jiak"};
            s.Validate();
        }
    }
}
