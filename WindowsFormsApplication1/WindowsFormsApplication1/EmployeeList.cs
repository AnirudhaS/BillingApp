using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class EmployeeList
    {
        public List<Employee> employee;

        public EmployeeList()
        {
            employee = new List<Employee>();
            
            StreamReader read = new StreamReader("emp_login.dat");
            try
            {
                do
                {
                    string username = read.ReadLine();
                    string password = read.ReadLine();
                    employee.Add(new Employee(username, password));
                } while (read.Peek() != -1);
            }

            catch
            {
                // Read Write Error.
            }
            finally
            {
                read.Close();
            }
        }
    }
}
