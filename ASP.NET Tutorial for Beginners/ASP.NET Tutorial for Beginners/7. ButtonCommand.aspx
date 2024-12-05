<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="7. ButtonCommand.aspx.cs" Inherits="ASPDotNET_Tutorial_for_Beginners.ButtonCommand" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
	 <asp:Button ID="Print" runat="server" Text="Print" OnCommand="OnCommandButton_Click" CommandName="Print"/>
	 <asp:Button ID="Delete" runat="server" Text="Delete"  OnCommand="OnCommandButton_Click"  CommandName="Delete"/>
	 <asp:Button ID="Top100" runat="server" Text="Top100"  OnCommand="OnCommandButton_Click"  CommandName="Show" CommandArgument="Top10"/>
	 <asp:Button ID="Bottom10" runat="server" Text="Bottom10"  OnCommand="OnCommandButton_Click"  CommandName="Show"  CommandArgument="Bottom10"/>
	 <asp:Label ID="Output" runat="server"></asp:Label>
    </div>

   
  </form>
</body>
</html>

