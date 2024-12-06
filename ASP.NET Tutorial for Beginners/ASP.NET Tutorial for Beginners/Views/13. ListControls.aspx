<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="13. ListControls.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.ListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>

  <form id="form1" runat="server">
    <h1>Items Added In Design</h1>
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
	 <asp:ListItem Value="1" Text="Item 1"></asp:ListItem>
	 <asp:ListItem Value="2" Text="Item 2"></asp:ListItem>
	 <asp:ListItem Value="3" Text="Item 3"></asp:ListItem>
    </asp:CheckBoxList>
    <asp:DropDownList ID="DropDownList1" runat="server">
	 <asp:ListItem Value="1" Text="Item 1"></asp:ListItem>
	 <asp:ListItem Value="2" Text="Item 2"></asp:ListItem>
	 <asp:ListItem Value="3" Text="Item 3"></asp:ListItem>
    </asp:DropDownList>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
	 <asp:ListItem Value="1" Text="Item 1"></asp:ListItem>
	 <asp:ListItem Value="2" Text="Item 2"></asp:ListItem>
	 <asp:ListItem Value="3" Text="Item 3"></asp:ListItem>
    </asp:RadioButtonList>
    <asp:ListBox ID="ListBox1" runat="server">
	 <asp:ListItem Value="1" Text="Item 1"></asp:ListItem>
	 <asp:ListItem Value="2" Text="Item 2"></asp:ListItem>
	 <asp:ListItem Value="3" Text="Item 3"></asp:ListItem>
    </asp:ListBox>
    <asp:BulletedList ID="BulletedList1" runat="server">
	 <asp:ListItem Value="1" Text="Item 1"></asp:ListItem>
	 <asp:ListItem Value="2" Text="Item 2"></asp:ListItem>
	 <asp:ListItem Value="3" Text="Item 3"></asp:ListItem>
    </asp:BulletedList>

    <h1>Items Added In CodeBehind</h1>
    <asp:CheckBoxList ID="CheckBoxList2" runat="server">
    </asp:CheckBoxList>
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
    <asp:RadioButtonList ID="RadioButtonList2" runat="server">
    </asp:RadioButtonList>
    <asp:ListBox ID="ListBox2"  SelectionMode="Multiple" runat="server"></asp:ListBox>
    <asp:BulletedList ID="BulletedList2" runat="server" DisplayMode="LinkButton">
    </asp:BulletedList>
    <asp:Button runat="server" Text="Click" OnClick="Unnamed1_Click"/>
  </form>

</body>
</html>
