<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="20. Literal.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.Literal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>

	 <asp:Label runat="server" ID="Label1" Font-Bold="true" ForeColor="Red">
	  <%= Server.HtmlEncode("<script>alert('Label')</script>") %>
	 </asp:Label>
	 <br />
	 <asp:Literal ID="Literal1" mode="Encode" runat="server" Text="<script>alert('Literal')</script>"></asp:Literal>
    </div>

  </form>
</body>
</html>
