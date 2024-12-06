<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="17. MultiView.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>

<body>

  <form id="form1" runat="server">
    <asp:MultiView ID="Multiview1" runat="server">

	 <asp:View ID="ViewPersonalDetails" runat="server">
	   <table style="border: 1px solid black">
		<tr>
		  <td colspan="2">
		    <h2>Step 1 - Personal Details</h2>
		  </td>
		</tr>
		<tr>
		  <td>First Name</td>
		  <td>
		    <asp:TextBox ID="txtFN" runat="server"></asp:TextBox></td>
		</tr>

		<tr>
		  <td>Last Name</td>
		  <td>
		    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
		  <td>Gender</td>
		  <td>
		    <asp:DropDownList ID="ddlGender" runat="server">
			 <asp:ListItem Value="M" Text="Male"></asp:ListItem>
			 <asp:ListItem Value="F" Text="Feale"></asp:ListItem>
		    </asp:DropDownList></td>
		</tr>
		<tr>

		  <td colspan="2" style="text-align: right">
		    <asp:Button ID="ButtonStep2" Text="Step 2 >>" runat="server" OnClick="ButtonStep2_Click"></asp:Button></td>
		</tr>
	   </table>
	 </asp:View>

	 <asp:View ID="ViewContactdetails" runat="server">
	   <table style="border: 1px solid black">
		<tr>
		  <td colspan="2">
		    <h2>Step2 - Contact Details</h2>
		  </td>
		</tr>
		<tr>
		  <td>Mobile Number</td>
		  <td>
		    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
		</tr>
		<tr>
		  <td>Email Address</td>
		  <td>
		    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
		</tr>

		<tr>
		  <td colspan="2" style="text-align: left">
		    <asp:Button ID="ButtonStep1" Text="<< Step 1" runat="server" OnClick="ButtonStep1_Click" ></asp:Button></td>
		  <td style="text-align: right">
		    <asp:Button ID="ButtonStep3" Text="Step 3 >>" runat="server" OnClick="ButtonStep3_Click" ></asp:Button></td>
		</tr>
	   </table>
	 </asp:View>

	 <asp:View ID="ViewSummary" runat="server">
	   <table style="border: 1px solid black">
		<tr>
		  <td colspan="2">
		    <h2>Step 3 - Summary </h2>
		  </td>
		</tr>
		<tr>
		  <td>
		    <h2>Personal Details</h2>
		  </td>
		</tr>
		<tr>
		  <td>First Name</td>
		  <td>:<asp:Label runat="server" ID="Label1"></asp:Label></td>
		</tr>
		<tr>
		  <td>Last Name</td>

		  <td>:<asp:Label runat="server" ID="Label2"></asp:Label></td>
		</tr>
		<tr>
		  <td>Gender</td>
		  <td>:<asp:Label runat="server" ID="Label3"></asp:Label></td>
		</tr>
		<tr>
		  <td>
		    <h2>Contact Details</h2>
		  </td>
		</tr>
		<tr>
		  <td>Email Address</td>
		  <td>:<asp:Label runat="server" ID="LblEmail"></asp:Label></td>
		</tr>
		<tr>
		  <td>Mobile Number</td>
		  <td>:<asp:Label runat="server" ID="lblMobile"></asp:Label></td>
		</tr>

		<tr>
		  <td colspan="2" style="text-align: left">
		    <asp:Button ID="ButtonStep21" Text="<< Step 2" runat="server" OnClick="ButtonStep2_Click"></asp:Button></td>
		  <td style="text-align: right">
		    <asp:Button ID="btnSubmit" Text="Submit >>" runat="server" OnClick="btnSubmit_Click" ></asp:Button></td>
		</tr>
	   </table>
	 </asp:View>

    </asp:MultiView>
  </form>

</body>
</html>

