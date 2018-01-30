using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeManagement.BusinessLogic;
using EmployeeManagement.Common;
namespace EmployeeManagement.UI
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        ProcessEmployeeInsert employeeInsertObject = new ProcessEmployeeInsert();
        EmployeeDTO dtoObject = new EmployeeDTO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterButton_Click(object sender, EventArgs e)
        {
            dtoObject.EmployeeId = int.Parse(IdTextBox.Text);
            dtoObject.EmployeeName = NameTextBox.Text;
            dtoObject.Designation = DesignationTextBox.Text;
            dtoObject.Salary = int.Parse(SalaryTextBox.Text);
            employeeInsertObject.Employees = dtoObject;
            int rowsAffected =employeeInsertObject.Invoke();

        }
    }
}