<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="18..1 WizardControlTemplates.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._18_WizardControlTemplates" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
</head>
<body>

  <form id="form1" runat="server">
    <div>
	 <asp:Wizard ID="Wizard1" runat="server" >
	   <FinishNavigationTemplate>
		<asp:Button ID="FinishPreviousButton" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" />
		<asp:Button ID="FinishButton" runat="server" CommandName="MoveComplete" Text="Finish" />
	   </FinishNavigationTemplate>
	   <SideBarStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="False" />
	   <SideBarTemplate>
		<asp:DataList ID="SideBarList" runat="server">
		  <ItemTemplate>
		    <asp:LinkButton ID="SideBarButton" runat="server"></asp:LinkButton>
		  </ItemTemplate>
		  <SelectedItemStyle Font-Bold="True" />
		</asp:DataList>
	   </SideBarTemplate>
	   <StartNavigationTemplate>
		<asp:Button ID="StartNextButton" runat="server" CommandName="MoveNext" Text="Next" OnClientClick="return confirm('Are you sure to go to next step');"/>
	   </StartNavigationTemplate>
	   <StepNavigationTemplate>
		<asp:Button ID="StepPreviousButton" UseSubmitBehavior="false" runat="server" CausesValidation="False" CommandName="MovePrevious" Text="Previous" OnClientClick="return alert('You are going back');"/>
		<asp:Button ID="StepNextButton" runat="server" CommandName="MoveNext" Text="Next" OnClientClick="return confirm('Are you sure to go to next step');"/>
	   </StepNavigationTemplate>
	   <WizardSteps>
		<asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
		  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
		</asp:WizardStep>
		<asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
		  <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
		</asp:WizardStep>
		<asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
		  <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
		</asp:WizardStep>
	   </WizardSteps>
	 </asp:Wizard>
    </div>
  </form>
</body>
</html>
