<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="12. CheckBoxAndListBox.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._12_CheckBoxAndListBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>

  <form id="form1" runat="server">
    <div>
	 <asp:CheckBoxList ID="CheckBoxList1" AutoPostBack="true" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
	   <asp:ListItem Value="SSC">Madhyamik</asp:ListItem>
	   <asp:ListItem Value="HS">Higher Secondary</asp:ListItem>
	   <asp:ListItem Value="UG">Under Graduate</asp:ListItem>
	   <asp:ListItem Value="G">Graduate</asp:ListItem>
	   <asp:ListItem Value="PG">Post Graduate</asp:ListItem>
	 </asp:CheckBoxList><br />
	 <asp:ListBox ID="ListBox1" AutoPostBack="true" runat="server" SelectionMode="Multiple" Height="180px" Width="260px"></asp:ListBox><br />
	 <asp:Label ID="Label1" runat="server"></asp:Label>
    </div>
  </form>

</body>
</html>
