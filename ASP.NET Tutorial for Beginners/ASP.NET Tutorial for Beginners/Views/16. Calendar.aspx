<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="16. Calendar.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.Calendar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>

<body>

  <form id="form1" runat="server">
   
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:ImageButton ID="ImageButton1" runat="server" Height="28px" ImageUrl="~/Images/Calendar.png" OnClick="ImageButton1_Click" Width="29px" />
    <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" Caption="Testing Calendar" CaptionAlign="Top" DayNameFormat="FirstTwoLetters" FirstDayOfWeek="Monday" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged" OnVisibleMonthChanged="Calendar1_VisibleMonthChanged" SelectionMode="DayWeekMonth" ShowGridLines="True" Width="220px">
	 <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
	 <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
	 <OtherMonthDayStyle ForeColor="#CC9966" />
	 <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
	 <SelectorStyle BackColor="#FFCC66" />
	 <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
	 <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
    </asp:Calendar>
  </form>

</body>
</html>

