<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retrieveemployee.aspx.cs" Inherits="employeemanagement.retrieveemployee" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        &nbsp;<asp:Button ID="btnhome" runat="server" OnClick="btnhome_Click" Text="Home" />
        <br />
        <br />
        <br />
        
        EmpID<br />
        <asp:Label ID="lbl_msg" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="txt_empid" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnempsearch" runat="server" Text="Search" OnClick="btnempsearch_Click" />
        <br />
        
        Initials<br />
        <asp:TextBox ID="txt_initials" runat="server"></asp:TextBox>
        <br />
        Surname<br />
        <asp:TextBox ID="txt_surname" runat="server"></asp:TextBox>
        <br />
        Name<br />
        <asp:TextBox ID="txt_name" runat="server"></asp:TextBox>
        <br />
        Mobile<br />
        <asp:TextBox ID="txt_mobile" runat="server"></asp:TextBox>
        <br />
        Current Address<br />
        <asp:TextBox ID="txt_curraddress" runat="server"></asp:TextBox>
        <br />
        Current Designation<br />
        <asp:TextBox ID="txt_currdesignation" runat="server"></asp:TextBox>
        <br />
        Current Salary Package<br />
        <asp:TextBox ID="txt_currsalary" runat="server"></asp:TextBox>
        <br />
        Department<br />
        <asp:TextBox ID="txt_department" runat="server"></asp:TextBox>
        <br />
        <br />
        
        </div>
    </form>
</body>
</html>

