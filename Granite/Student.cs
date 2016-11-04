using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class Student
    {
        public string enumber { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public bool testTaken { get; set; }

        public Student(string e, string f, string l)
        {
            this.enumber = e;
            this.first = f;
            this.last = l;
            testTaken = false;
        }
    }
}
