using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Employee
    {
        public string name;
        public string user, pass;

        public Employee(string u, string p)
        {
            user = u;
            pass = p;
            name = u;
        }
    }
}
