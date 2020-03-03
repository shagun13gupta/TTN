<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 395px;
        }
        .auto-style2 {
            width: 100%;
            height: 394px;
        }
        .auto-style3 {
            height: 138px;
        }
        .auto-style4 {
            height: 138px;
            width: 299px;
        }
        .auto-style5 {
            width: 299px;
        }
        .auto-style6 {
            height: 138px;
            width: 223px;
        }
        .auto-style7 {
            width: 223px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <table class="auto-style2">
                <tr>
                    <td class="auto-style4">
                        <asp:GridView ID="GridView1" runat="server" Width="172px">
                        </asp:GridView>
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:GridView ID="GridView3" runat="server">
                        </asp:GridView>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:GridView ID="GridView2" runat="server">
                        </asp:GridView>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Connected" Width="151px" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Disconnected" Width="155px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
