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
    <script type="text/javascript">
        function OpenNewWindow() {
            var Name = document.getElementById('TextBox1').value;
            window.open('3. ViewStateTextBox.aspx?ValuePassed=' + Name, '_self', 'toolbarino, directories= yes, location - no, resizable = no, width = 500px, height= 500px"', true);
        }
    </script>
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
            <fieldset>
                <legend>Windows.Open</legend>
                <asp:Button runat="server" ID="Button1"
                    Text="Open Window"
                    OnClientClick="window.open('3. ViewStateTextBox.aspx');" />

                <input id="htmlButton" type="button" value="HTML Button" onclick="OpenNewWindow()" />

                <asp:Button runat="server" ID="Button2"
                    Text="Open Window Back end" OnClick="Button2_Click" />
            </fieldset>

        </div>
    </form>
</body>
</html>
