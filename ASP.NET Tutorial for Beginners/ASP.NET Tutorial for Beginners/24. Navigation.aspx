<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="24. Navigation.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.Navigation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
        fieldset {
            margin: 5px;
        }

        HyperLink {
            margin: 50px;
        }
    </style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <fieldset>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <legend>Hyperlink</legend>
                <asp:HyperLink runat="server" ID="internal" Text="Dynamic Controls" NavigateUrl="~/22. DynamicControl.aspx"></asp:HyperLink>&nbsp;&nbsp;
                <asp:HyperLink runat="server" ID="External" Text="Google" NavigateUrl="https://www.google.co.in"></asp:HyperLink>&nbsp;&nbsp;
            </fieldset>
            <fieldset>
                <legend>Responser.Redirect</legend>
                <asp:Button runat="server" ID="responseRedirect" Text="Response.Redirect Internal " CommandName="responseRedirect" CommandArgument="internal" OnCommand="responseRedirect_command" />&nbsp;&nbsp;
                <asp:Button runat="server" ID="responseRedirectEx" Text="Response.Redirect External" CommandName="responseRedirect" CommandArgument="External" OnCommand="responseRedirect_command" />&nbsp;&nbsp;
            </fieldset>
            <fieldset>
                <legend>Server.Transfer</legend>
                <asp:Button runat="server" ID="serverTransfer" Text="Server.Transfer Internal" CommandName="serverTransfer" CommandArgument="internal" OnCommand="responseRedirect_command" />&nbsp;&nbsp;
                <asp:Button runat="server" ID="serverTransferEx" Text="Server.Transfer External" CommandName="serverTransfer" CommandArgument="External" OnCommand="responseRedirect_command" />
            </fieldset>
            <fieldset>
                <legend>Server.Execute</legend>
                <asp:Button runat="server" ID="serverExecute" Text="Server.Execute Internal" CommandName="serverExecute" CommandArgument="internal" OnCommand="responseRedirect_command" />&nbsp;&nbsp;
                <asp:Button runat="server" ID="serverExecuteEx" Text="Server.Execute External" CommandName="serverExecute" CommandArgument="External" OnCommand="responseRedirect_command" />
                <asp:Label runat="server" ID="lblServerExecute"></asp:Label>
            </fieldset>
            <fieldset>
                <legend>Cross-Page PostBack </legend>
                <asp:Button runat="server" ID="CrossPage_PostBack" Text="CrossPage_PostBack Internal" PostBackUrl="~/3. ViewStateTextBox.aspx" />&nbsp;&nbsp;
                <asp:Button runat="server" ID="CrossPage_PostBackStronglyTyped" Text="CrossPage_PostBack StronglyTyped" PostBackUrl="~/3. ViewStateTextBox.aspx" />&nbsp;&nbsp;
   
            </fieldset>
            <asp:Button runat="server" ID="Button1"
                Text="Open Window"
                OnClientClick="window.open();" />

            <%-- function Opentievilindow() var Name document.getElementById('txtliame').value; var Email document.getElementById('txtEmail').value; window.open('WebForm2.aspx?Name Name &Email Email, '_blank', 'toolbarino, directories yes, location-no, resizable=yes, width=500px, height 500px", true); PRAGIM Technologies | 9900113931 | www.pragimtech.com--%>
        </div>
    </form>
</body>
</html>
