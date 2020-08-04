<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IMATStartPage.aspx.cs" Inherits="IMATFrontOffice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 5px;
            width: 120px;
        }
        #TextArea1 {
            height: 29px;
            width: 174px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Height="16px" style="margin-left: 26px" Width="118px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblLoginUser" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtLoginUser" runat="server" style="margin-left: 10px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="txtUser" runat="server" Height="16px" Width="118px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblLoginPass" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtLoginPass" runat="server" style="margin-left: 10px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Pasword: "></asp:Label>
            <asp:TextBox ID="txtPass" runat="server" style="margin-left: 9px" Width="118px"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" style="margin-left: 26px" Width="118px"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnRegister" runat="server" Text="Register" OnClick="BtnRegister_Click" Width="115px" />
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" style="margin-left: 294px" Width="115px" />
        </p>
        <p>
            <asp:Label ID="lblErrorOrConfirm" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
