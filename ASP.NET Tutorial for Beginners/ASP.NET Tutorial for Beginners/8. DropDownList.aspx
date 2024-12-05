<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="8. DropDownList.aspx.cs" Inherits="ASPDotNET_Tutorial_for_Beginners.DropDownList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
	 From Design<br />
	 <asp:DropDownList runat="server" ID="DropDownList3">
	   <asp:ListItem Value="0" Text="SSC"></asp:ListItem>
	   <asp:ListItem Value="1" Text="UPSC"></asp:ListItem>
	   <asp:ListItem Value="2" Text="IPS"></asp:ListItem>
	 </asp:DropDownList><br />
	 From CodeBehind<br />
	 <asp:DropDownList runat="server" DataTextField="CITY_NAME" DataValueField="CITY_CD" ID="DropDownList1"></asp:DropDownList><br />
	 From DataBase<br />
	 <asp:DropDownList runat="server" DataTextField="CITY_NAME" DataValueField="CITY_CD" ID="DropDownList2"></asp:DropDownList><br />
	 From XML<br />
	 <asp:DropDownList runat="server" ID="DropDownList4"></asp:DropDownList><br />
	 <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
	 ----------------------------------Cascading-------------------------------<br /><br />
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
