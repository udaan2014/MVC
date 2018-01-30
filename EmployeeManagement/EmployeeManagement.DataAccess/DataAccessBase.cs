using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DataAccess
{
    public class DataAccessBase
    {
        protected string StoredProcedureName { get; set; }
        protected string ConnectionString
        {
            get {
                return ConfigurationManager.ConnectionStrings["EmployeeManagementConnectionString"].ConnectionString;
            }
        }
    }
}
