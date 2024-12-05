<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="15. AdRotater.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.AdRotater" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>

<body>

  <form id="form1" runat="server">
   <asp:AdRotator ID="addRotater" runat="server" Target="_blank" AdvertisementFile="~/contents/AddData.xml"></asp:AdRotator>
  </form>

</body>
</html>
