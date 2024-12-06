<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="21. Panel.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners.Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="Select User" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Admin User" Value="Admin"></asp:ListItem>
                <asp:ListItem Text="Non admin User" Value="Non Admin"></asp:ListItem>
            </asp:DropDownList>
            
            <asp:RequiredFieldValidator ID="rfvUser" ControlToValidate="DropDownList1" runat="server" ErrorMessage="User is selected" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>

            <asp:Panel ID="AdminPanel" runat="server">                <%--only changed, Rest ate the same--%>
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="AdminGreeting" runat="server" Font-Size="XX-Large" Text="You are logged in as an administrator"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="AdminsameLabel" runat="server" Text="Admin Name:"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox ID="AdminNameTextBox" runat="server" Text="Tom"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="AdminRegionLabel" runat="server" Text="Admin Region:"></asp:Label></td>

                        <td>
                            <asp:TextBox ID="AdminkegionTextBox" runat="server" Text="Asia"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="AdminActionstabel" runat="server" Text="Actions:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" TextMode="MultiLine"
                                Text="There are 4 user queries to be answered by the end of Decemeber 25th 2024." Font-Bold="True"></asp:TextBox>
                        </td>


                    </tr>


                </table>

            </asp:Panel>                                              <%--only changed, Rest ate the same--%>

            <asp:Panel ID="NonAdminPanel" runat="server">             <%--only changed, Rest ate the same--%>
                <table>
                    <tr>
                        <td colspan="2">
                            <asp:Label ID="NonAdminGreeting" runat="server" Font-Size="XX-Large" Text="Welcome Guest!"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="nonAdminLabel" runat="server" Text="User Name:"></asp:Label>
                        </td>

                        <td>
                            <asp:TextBox ID="nonAdminText" runat="server" Text="Guest"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="NonAdminRegionLabel" runat="server" Text="User Region:"></asp:Label></td>

                        <td>
                            <asp:TextBox ID="NonAdminRegionText" runat="server" Text="UK"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="NonAdminCityLabel" runat="server" Text="City"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="NonAdminCityText" runat="server" Font-Size="Medium"
                                Text="London"></asp:TextBox>
                        </td>


                    </tr>


                </table>

            </asp:Panel>                                              <%--only changed, Rest ate the same--%>
        </div>

    </form>
</body>
</html>
