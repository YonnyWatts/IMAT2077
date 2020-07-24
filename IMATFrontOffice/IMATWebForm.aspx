<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IMATWebForm.aspx.cs" Inherits="IMATFrontOffice.WebForm1" %>

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
            <asp:TextBox ID="txtName" runat="server" Height="16px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Pasword: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblEmail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <p>
            <asp:CheckBox ID="cbPaymentInfo" runat="server" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="BtnRegister" runat="server" Text="Register New Account" />
            <asp:Button ID="btnLogin" runat="server" Text="Login with Account" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
