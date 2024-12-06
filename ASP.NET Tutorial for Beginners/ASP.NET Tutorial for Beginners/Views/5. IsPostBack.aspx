<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="5. IsPostBack.aspx.cs" Inherits="ASPDotNET_Tutorial_for_Beginners.IsPostBackEvent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
	 <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
	 <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
	 <br />
	 <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
	 <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
	  <br />
	  <asp:Label ID="Label3" runat="server" Text="City"></asp:Label>
      <asp:DropDownList ID="DropDownList1" runat="server" >
	 </asp:DropDownList>
	 <br />
	 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
  </form>
</body>
</html>
