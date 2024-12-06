<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="10. CheckRadioBulletBoxList.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.CheckRadioBulletBoxList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
	 CheckBoxList
          <asp:CheckBoxList ID="CheckBoxList1" AutoPostBack="true" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
		  <asp:ListItem Value="SSC">Madhyamik</asp:ListItem>
		  <asp:ListItem Value="HS">Higher Secondary</asp:ListItem>
		  <asp:ListItem Value="UG">Under Graduate</asp:ListItem>
		  <asp:ListItem Value="G">Graduate</asp:ListItem>
		  <asp:ListItem Value="PG">Post Graduate</asp:ListItem>
		</asp:CheckBoxList><br />
	 <asp:Button Text="Print" runat="server" ID="btnClick" OnCommand="btnClick_Click" CommandName="Print" />
	 <asp:Button Text="Select All" runat="server" ID="btnSelectAll" OnCommand="btnClick_Click" CommandName="SelectAll" />
	 <asp:Button Text="De Select All" runat="server" ID="btnDeselectAll" OnCommand="btnClick_Click" CommandName="DeSelectAll" />
    </div>
    -------------------------------------------------------------------------------------------------------------------------------
              <div>
			 RadioButtonList
          <asp:RadioButtonList ID="CheckBoxList2" AutoPostBack="true" runat="server" RepeatDirection="Horizontal" OnSelectedIndexChanged="CheckBoxList2_SelectedIndexChanged">
		  <asp:ListItem Value="SSC">Madhyamik</asp:ListItem>
		  <asp:ListItem Value="HS">Higher Secondary</asp:ListItem>
		  <asp:ListItem Value="UG">Under Graduate</asp:ListItem>
		  <asp:ListItem Value="G">Graduate</asp:ListItem>
		  <asp:ListItem Value="PG">Post Graduate</asp:ListItem>
		</asp:RadioButtonList><br />
			 <asp:Button Text="Print" runat="server" ID="Button1" OnCommand="btnClick_Click" CommandName="Radio" />

		    </div>
    -------------------------------------------------------------------------------------------------------------------------------
              <div>
			 BulletedList
          <asp:BulletedList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" BulletStyle="UpperAlpha" DisplayMode="LinkButton" OnClick="RadioButtonList1_Click" Target="_blank">
		  <asp:ListItem Value="https://www.google.co.in">Google</asp:ListItem>
		  <asp:ListItem Value="https://www.msn.com/en-in">MSN</asp:ListItem>

		</asp:BulletedList>
			 <br />


		    </div>
  </form>
</body>
</html>
