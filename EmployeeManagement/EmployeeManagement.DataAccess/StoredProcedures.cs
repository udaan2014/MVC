using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess
{
    public static class StoredProcedures
    {
        public const string GetEmployeeDetails = "[USP_GetEmployeeDetails]";
        public const string AddEmployeeDetails = "[USP_InsertEmployeeDetails]";
        public const string DeleteEmployeeDetails = "[USP_DeleteEmployeeDetails]";
        public const string UpdateEmployeeDetails = "[USP_UpdateEmployeeDetails]";
    }
}
