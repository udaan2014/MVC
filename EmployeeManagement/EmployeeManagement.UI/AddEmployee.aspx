<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="EmployeeManagement.UI.AddEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="IdLabel" runat="server" Text="Id"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="NameLabel" runat="server" Text="Name"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="DesignationLabel" runat="server" Text="Designation"></asp:Label><asp:TextBox ID="DesignationTextBox" runat="server"></asp:TextBox><br />
            <asp:Label ID="SalaryLabel" runat="server" Text="Salary"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="SalaryTextBox" runat="server"></asp:TextBox><br />
            <asp:Button ID="RegisterButton" runat="server" Text="Register" OnClick="RegisterButton_Click" />
        </div>
    </form>
</body>
</html>
