<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="6. CheckBox.aspx.cs" Inherits="ASPDotNET_Tutorial_for_Beginners.CheckBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">
        <div>
          <asp:CheckBox ID="CheckBox1" Text="Graduate" runat="server" />
          <asp:CheckBox ID="CheckBox2" Text="Post Graduate" runat="server" />
          <asp:CheckBox ID="CheckBox3" Text="Doctorate" runat="server" />

            <asp:Button ID="btn" Text="Click" runat="server" OnClick="btn_Click" />
        </div>
    </form>
</body>
</html>
