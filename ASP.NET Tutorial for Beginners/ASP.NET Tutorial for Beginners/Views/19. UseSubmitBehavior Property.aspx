<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="19. UseSubmitBehavior Property.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._18_UseSubmitBehavior_Property" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
	 <asp:Literal ID="Literal1" runat="server" Text="Name"></asp:Literal>
	 <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
	 <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear"  />
	 <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
	 <br />
	 <asp:Label ID="lblMsg" runat="server" Font-Bold="True" ForeColor="#009933"></asp:Label>
    </div>

  </form>
</body>
</html>
