using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class User
    {
        public string username { get; set; }
        public string first { get; set; }
        public string last { get; set; }
        public string email { get; set; }
        public string role { get; set; }
        public string password { get; set; }
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
