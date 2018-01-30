using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Common
{
    public class EmployeeDTO
    {
        public int EmployeeId{ get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
}
