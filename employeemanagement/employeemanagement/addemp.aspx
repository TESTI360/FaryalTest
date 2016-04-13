<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addemp.aspx.cs" Inherits="employeemanagement.addemp1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnhome" runat="server" Text="Home" OnClick="btnhome_Click" />
        <br />
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
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
    <asp:Button ID="btnaddemp" runat="server"  Text="Add" OnClick="btnaddemp_Click"  />
        
        
    
    </div>
    </form>
</body>
</html>
