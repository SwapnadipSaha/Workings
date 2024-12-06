<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="18. WizardControl.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._18_WizardControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>

  <form id="form1" runat="server">
    <div>
	 <asp:Wizard ID="Wizard1" runat="server" OnFinishButtonClick="Wizard1_FinishButtonClick" OnNextButtonClick="Wizard1_NextButtonClick1" CancelDestinationPageUrl="~/17. MultiView.aspx" DisplayCancelButton="True" DisplaySideBar="False" HeaderText="Wizard Demo -- Personal" OnActiveStepChanged="Wizard1_ActiveStepChanged" OnCancelButtonClick="Wizard1_CancelButtonClick" OnDataBinding="Wizard1_DataBinding" OnDisposed="Wizard1_Disposed" OnInit="Wizard1_Init" OnLoad="Wizard1_Load" OnPreRender="Wizard1_PreRender" OnPreviousButtonClick="Wizard1_PreviousButtonClick" OnSideBarButtonClick="Wizard1_SideBarButtonClick">
	   <SideBarStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
	   <WizardSteps>
		<asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1 -- Personal Details">
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
				<asp:ListItem Value="F" Text="FeMale"></asp:ListItem>
			   </asp:DropDownList></td>
		    </tr>

		  </table>
		</asp:WizardStep>
		<asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2 -- Contact Details">
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


		  </table>
		</asp:WizardStep>
		<asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3 -- Summary">
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

		    
		  </table>
		</asp:WizardStep>
	   </WizardSteps>
	 </asp:Wizard>
    </div>
  </form>
</body>
</html>
