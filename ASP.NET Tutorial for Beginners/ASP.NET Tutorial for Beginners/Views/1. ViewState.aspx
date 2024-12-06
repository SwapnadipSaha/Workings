<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1. ViewState.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>

	 <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
	 <asp:Button runat="server" ID="Button1" Text="Click Me" OnClick="Button1_Click"></asp:Button>
	 <asp:Button runat="server" ID="Button2" Text="Click Me 2" OnClick="Button2_Click"></asp:Button>
	 <asp:Button runat="server" ID="Button3" Text="Click Me 3" OnClick="Button3_Click"></asp:Button>
    </div>
    <input id="Text1" placeholder="HTML ctrl" type="text" />
    <input id="Text2" runat="server" placeholder="HTML ctrl runat server" type="text" />
    <asp:Button runat="server" ID="Button4" Text="Click Me 4"></asp:Button>

  </form>
</body>
</html>
