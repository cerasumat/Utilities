using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using CeraSumat.Utilities.Parser;
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
            var s = new Student {Id = 4, Name = "Jiak"};
            //object t = (object)s;
            //Student d = t.To<Student>();
            s.Validate();
        }
    }
}
