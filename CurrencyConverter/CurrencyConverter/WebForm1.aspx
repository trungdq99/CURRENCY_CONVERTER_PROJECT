<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CurrencyConverter.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnSay" runat="server" Text="Say" OnClick="btnSay_Click" />
            <asp:Label ID="lbSay" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txtFrom" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlFromCurrency" runat="server">
                <asp:ListItem Selected="True">VND</asp:ListItem>
                <asp:ListItem>AUD</asp:ListItem>
                <asp:ListItem>GBP</asp:ListItem>
                <asp:ListItem>HKD</asp:ListItem>
                <asp:ListItem>JPY</asp:ListItem>
                <asp:ListItem>SGD</asp:ListItem>
                <asp:ListItem>THB</asp:ListItem>
                <asp:ListItem>USD</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTo" runat="server" ReadOnly="True"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlToCurrency" runat="server">
                <asp:ListItem>VND</asp:ListItem>
                <asp:ListItem>AUD</asp:ListItem>
                <asp:ListItem>EUR</asp:ListItem>
                <asp:ListItem>GBP</asp:ListItem>
                <asp:ListItem>HKD</asp:ListItem>
                <asp:ListItem>JPY</asp:ListItem>
                <asp:ListItem>SGD</asp:ListItem>
                <asp:ListItem>THB</asp:ListItem>
                <asp:ListItem Selected="True">USD</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnConvert" runat="server" OnClick="btnConvert_Click" Text="Convert" />
        </div>
    </form>
</body>
</html>
