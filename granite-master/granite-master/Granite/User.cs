using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class User
    {
        private string username { get; set; }
        private string first { get; set; }
        private string last { get; set; }
        private string email { get; set; }
        private string role { get; }
        public User(string user, string f, string l, string email, string e, string r)
        {
            this.username = user;
            this.first = f;
            this.last = l;
            this.email = e;
            this.role = r;
        }

        public User(string user)
        {
            this.username = user;
        }
        public void giveTest()
        {
            //give test logic
        }
    }
}
