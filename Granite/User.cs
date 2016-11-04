using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    class User
    {
        internal string username { get; set; }
        internal string first { get; set; }
        internal string last { get; set; }
        internal string email { get; set; }
        internal string role { get; set; }
        internal string password { get; set; }
        public User(string user, string f, string l, string email, string e, string r, string p)
        {
            this.username = user;
            this.first = f;
            this.last = l;
            this.email = e;
            this.role = r;
            this.password = p;
        }
        public User(string user)
        {
            username = user;
        }
        public User()
        {

        }
        public void giveTest()
        {
            //give test logic
        }
    }
}
