<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="14. FileUpload.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.FileUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>

  <form id="form1" runat="server">
    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
    <asp:Button runat="server" id="Upload" Text="Click" OnClick="Upload_Click"/>
    <asp:Label  runat="server" id="lblStatus" ></asp:Label>
  </form>

</body>
</html>
