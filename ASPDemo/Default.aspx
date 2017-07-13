<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPDemo.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
    
        <asp:Label ID="Label1" runat="server" Text="Employee Id;"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Height="16px" style="margin-left: 35px"></asp:TextBox>
        <asp:LinkButton ID="LinkButtonGo" runat="server" OnClick="LinkButtonGo_Click">Go</asp:LinkButton>
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="TextBoxFName" runat="server" style="margin-left: 14px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="TextBoxLName" runat="server" style="margin-left: 19px"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
        <asp:TextBox ID="TextBoxDepartment" runat="server" style="margin-left: 14px"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
