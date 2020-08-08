<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IMATCustomerPage.aspx.cs" Inherits="IMATFrontOffice.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblUser" runat="server" Text="Username:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label4" runat="server" Text="Product: Custom Chair"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Password:"></asp:Label>
&nbsp;
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Price: 150 p/Chair"></asp:Label>
        <br />
        <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label6" runat="server" Text="Quantity: "></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" TextMode="Number" Width="16px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Order" />
        <br />
        <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblAccountNo" runat="server"></asp:Label>
        <p>
            <asp:CheckBox ID="cboxPay" runat="server" />
        </p>
        <p>
            <asp:Label ID="lblCardNumber" runat="server" Text="Card Number:"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txtCard" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Expiry Date:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtExpire" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblEmail0" runat="server" Text="Street:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStreet" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblName0" runat="server" Text="City:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblName1" runat="server" Text="Post Code:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPost" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnUpdate" runat="server" Text="Update Account Info" OnClick="btnUpdate_Click" />
    </form>
</body>
</html>
