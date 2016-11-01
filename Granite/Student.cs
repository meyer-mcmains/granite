using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    class Student
    {
        private string enumber { get; set; }
        private string first { get; set; }
        private string last { get; set; }
        private bool testTaken { get; set; }

        public Student(string e, string f, string l)
        {
            this.enumber = e;
            this.first = f;
            this.last = l;
            testTaken = false;
        }
    }
}
