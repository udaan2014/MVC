using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Common;
using EmployeeManagement.DataAccess;
namespace EmployeeManagement.BusinessLogic
{
    public class ProcessEmployeeInsert
    {
        public int Invoke()
        {
            try
            {
                DataAccess.Employee.AddEmployee addEmployeeObject = new DataAccess.Employee.AddEmployee();
                addEmployeeObject.Employees = this.Employees;
                return addEmployeeObject.Add();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public EmployeeDTO Employees { get; set; }
    }
}
