<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="8.1. CascadingDropDownList.aspx.cs" Inherits="ASPDotNET_Tutorial_for_Beginners.CascadingDropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>

	 <asp:DropDownList runat="server" ID="ddlCountry" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
	  
	 </asp:DropDownList><br /><br /><br />
	 <asp:DropDownList runat="server" ID="ddlState" AutoPostBack="true"  Enabled="false" OnSelectedIndexChanged="ddlState_SelectedIndexChanged">
	
	 </asp:DropDownList><br /><br /><br />
	 <asp:DropDownList runat="server" ID="ddlCity" AutoPostBack="true"   Enabled="false">
	 
	 </asp:DropDownList><br /><br /><br />
    </div>
  </form>
</body>
</html>
