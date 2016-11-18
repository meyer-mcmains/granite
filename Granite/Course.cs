using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class Course
    {
        private string id { get; set; }
        private string name { get; set; }
        private string type { get; set; }
        public Course()
        {
            this.id = "default";
            this.name = "default";
            this.type = "default";
        }
        public Course(string id, string n, string t)
        {
            this.id = id;
            this.name = name;
            this.type = type;
        }
        public string getId()
        {
            return this.id;
        }
        public void createQuestion()
        {
            //question creation logic
        }

        public Course(string id)
        {
            this.id = id;
        }
    }
}
