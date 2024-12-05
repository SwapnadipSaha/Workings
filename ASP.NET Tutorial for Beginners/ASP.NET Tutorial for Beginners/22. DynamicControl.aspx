<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="22. DynamicControl.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._22_DynamicControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    <b>control Type</b>
                </td>
                <td>
                    <asp:CheckBoxList ID="chkBoxListcontreltype" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Label" Value="Label"></asp:ListItem>
                        <asp:ListItem Text="TextBox" Value="TextBox"></asp:ListItem>
                        <asp:ListItem Text="Button" Value="Button"></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
                <td><b>How Many</b></td>
                <td>
                    <asp:TextBox ID="TextControlsCount" runat="server" Width="40px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnGenerateControl" runat="server" Text="Generate Controls" style="height: 29px" OnClick="btnGenerateControl_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <h3>Label Controls</h3>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <asp:Panel runat="server" ID="pnlLabels"></asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <h3>TextBox Controls</h3>
                </td>
            </tr>
            <tr>
                <td colspan="5" runat="server" id="tdTxtBoxes">
                    <%--<asp:Panel runat="server" ID="pnlTxtBoxes"></asp:Panel>--%>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <h3>Button Controls</h3>
                </td>
            </tr>
            <tr>
                <td colspan="5">
                    <%--<asp:Panel runat="server" ID="pnlButton"></asp:Panel>--%>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
