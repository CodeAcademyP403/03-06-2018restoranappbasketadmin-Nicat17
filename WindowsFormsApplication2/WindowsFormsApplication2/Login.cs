using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public class Login
    {
        public string name { get; set; }
        public string password { get; set; }

        public Login()
        {
            name = "admin";
            password = "12345";
        }
    }
}
