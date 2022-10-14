<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibaryFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 81px; width: 1486px">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server" Height="21px" OnTextChanged="TextBox1_TextChanged" style="margin-left: 15px" Width="200px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" style="margin-left: 20px" Width="180px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" style="margin-left: 122px; margin-top: 0px" Text="Login" Width="60px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
