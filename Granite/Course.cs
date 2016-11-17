using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    class Course
    {
        private string id { get; set; }
        private string name { get; set; }
        private string type { get; set; }

        public Course()
        {
        }
        public Course(string id, string n, string t)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }
        public Course(string id)
        {
            this.id = id;
        }
        public void createQuestion()
        {
            //question creation logic
        }
    }
}
