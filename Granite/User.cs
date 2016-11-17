using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granite
{
    public class User
    {
        internal string username { get; set; }
        internal string first { get; set; }
        internal string last { get; set; }
        internal string email { get; set; }
        internal string role { get; set; }
        internal string password { get; set; }
        public User(string user, string first, string last, string email, string role, string password)
        {
            this.username = user;
            this.first = first;
            this.last = last;
            this.email = email;
            this.role = role;
            this.password = password;
        }
        public User(string user)
        {
            username = user;
        }
        public User()
        {

        }
    }
}
