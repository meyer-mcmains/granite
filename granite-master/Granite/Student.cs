﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class Student
    {
        internal string enumber { get; set; }
        internal string first { get; set; }
        internal string last { get; set; }
        internal bool testTaken { get; set; }
        internal string concentration { get; set; }

        public Student(string e, string f, string l)
        {
            this.enumber = e;
            this.first = f;
            this.last = l;
            testTaken = false;
        }

        public Student(string e, string f, string l, string c)
        {
            this.enumber = e;
            this.first = f;
            this.last = l;
            this.concentration = c;
            testTaken = false;
        }
    }
}
