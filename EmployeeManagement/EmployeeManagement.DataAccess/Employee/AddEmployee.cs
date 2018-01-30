using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess.Employee
{
    public class AddEmployee : DataAccessBase
    {
        private EmployeeInsertParameters _employeeInsertParametersObject;
        public Common.EmployeeDTO Employees { get; set; }
        public AddEmployee()
        {
            StoredProcedureName = StoredProcedures.AddEmployeeDetails;
        }
        public int Add()
        {
            try
            {
                _employeeInsertParametersObject = new EmployeeInsertParameters(Employees);
                DataBaseHelper dbHelper = new DataBaseHelper(StoredProcedureName);
                dbHelper.Parameters = _employeeInsertParametersObject.Parameters;
                return dbHelper.ExcecuteQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private class EmployeeInsertParameters
        {
            public SqlParameter[] Parameters { get; set; }
            public Common.EmployeeDTO Employees { get; set; }
            public EmployeeInsertParameters(Common.EmployeeDTO employee)
            {
                Employees = employee;
                Build();
            }
            private void Build()
            {
                SqlParameter[] parameters =
                {
                new SqlParameter("@Id",Employees.EmployeeId),
                new SqlParameter("@Name",Employees.EmployeeName),
                new SqlParameter("@Designation",Employees.Designation),
                new SqlParameter("@Salary",Employees.Salary)
            };
                Parameters = parameters;
            }

        }
    }
  
}
