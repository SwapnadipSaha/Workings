<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="11. ListBox.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.ListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:ListBox ID="ListBox1" AutoPostBack="true" runat="server" SelectionMode="Multiple" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem Value="SSC">Madhyamik</asp:ListItem>
            <asp:ListItem Value="HS">Higher Secondary</asp:ListItem>
            <asp:ListItem Value="UG">Under Graduate</asp:ListItem>
            <asp:ListItem Value="G">Graduate</asp:ListItem>
            <asp:ListItem Value="PG">Post Graduate</asp:ListItem>
          </asp:ListBox><br />
          <asp:Button text="Print" runat="server" ID="btnClick" OnCommand="btnClick_Click" CommandName="Print"/>
         <%-- <asp:Button text="Select All" runat="server" ID="btnSelectAll" OnCommand="btnClick_Click" CommandName="SelectAll"/>
          <asp:Button text="De Select All" runat="server" ID="btnDeselectAll" OnCommand="btnClick_Click" CommandName="DeSelectAll"/>--%>
        </div>
    </form>
</body>
</html>
