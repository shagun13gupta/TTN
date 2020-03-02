<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewform.aspx.cs" Inherits="Q6.viewform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 202px">
    <form id="form1" runat="server">
        <div>

        <asp:Label ID="Label1" runat="server" Text="USERNAME"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Width="200px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="PASSWORD"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
        
            <br />

        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="SUBMIT" Width="85px" />
    </form>
</body>
</html>
