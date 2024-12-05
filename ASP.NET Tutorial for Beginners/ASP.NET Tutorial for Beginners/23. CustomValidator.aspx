<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="23. CustomValidator.aspx.cs" Inherits="ASP.NET_Tutorial_for_Beginners._23_CustomValidator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script type="text/javascript" text="javascript">
       function isEven(source, args)
        {
           if (args.Value == "") {
               args.IsValid = false;
           }
           else
           {
               if (args.Value % 2 == 0) {
                   args.IsValid = true;
               }
               else {
                   args.IsValid = false;
               }
           }
        }
    </script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Please enter a positive even number"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server"
                ErrorMessage="Please enter a positive even number."
                ForeColor="Red" Font-Bold="true"
                ControlToValidate="TextBox1"
                OnServerValidate="CustomValidator1_ServerValidate" ValidateEmptyText="False" ClientValidationFunction="isEven"></asp:CustomValidator>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblStatus" runat="server"></asp:Label>
    </form>
</body>
</html>
