<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CALCULATOR.aspx.cs" Inherits="Q2.CALCULATOR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 392px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <div class="auto-style1">
            <asp:TextBox ID="TextBox1" TextMode="Number" runat="server" Width="356px"   OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
             <br />
             <br />
             <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="1" Width="92px" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="2" Width="92px" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="3" Width="92px" OnClick="Button3_Click" />
            <asp:Button ID="add" runat="server" Text="+" Width="92px" OnClick="add_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="4" Width="92px" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="5" Width="92px" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="6" Width="92px" OnClick="Button6_Click" />
            <asp:Button ID="sub" runat="server" Text="-" Width="92px" OnClick="sub_Click" style="height: 26px" />
            <br />
            <br />
            <asp:Button ID="Button7" runat="server" Text="7" Width="92px" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="8" Width="92px" OnClick="Button8_Click" />
            <asp:Button ID="Button9" runat="server" Text="9" Width="92px" OnClick="Button9_Click" />
            <asp:Button ID="mul" runat="server" Text="*" Width="92px" OnClick="mul_Click" />
            <br />
            <br />
            <asp:Button ID="Button10" runat="server" Text="0" Width="92px" OnClick="Button10_Click" />
            <asp:Button ID="equal" runat="server" Text="=" Width="92px" OnClick="equal_Click" />
            <asp:Button ID="div" runat="server" Text="/" Width="92px" OnClick="div_Click" />
             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
             <br />
             <br />
        </div>
    </form>
</body>
</html>
