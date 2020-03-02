<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Q8.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">
   
    <div style="height: 302px">
        <table style="width: 100%; height: 289px;">
            <tr>
                <td style="width: 132px; height: 38px"></td>
                <td style="width: 509px; height: 38px; text-align:center; text-decoration: underline;"><strong>STUDENT DETAILS FORM</strong></td>
                <td style="height: 38px"></td>
            </tr>
            <tr>
                <td style="height: 230px; width: 132px"></td>
                <td style="height: 230px; width: 509px; vertical-align:top">
                    <table style="width:100%;">
                        <tr>
                            <td style="width: 126px">FirstName</td>
                            <td style="width: 276px">
                                <asp:TextBox ID="TextBox1" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 126px">LastName</td>
                            <td style="width: 276px">
                                <asp:TextBox ID="TextBox2" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Gender</td>
                            <td style="width: 276px">
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Email</td>
                            <td style="width: 276px">
                                <asp:TextBox ID="TextBox3" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Address</td>
                            <td style="width: 276px">
                                <asp:TextBox ID="TextBox4" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="height: 22px; width: 126px">Phone Number</td>
                            <td style="height: 22px; width: 276px;">
                                <asp:TextBox ID="TextBox5" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td style="height: 22px"></td>
                        </tr>
                        <tr>
                            <td style="width: 126px">&nbsp;</td>
                            <td style="width: 276px">
                                <asp:Button ID="Button1" runat="server" Text="Button" Width="119px" OnClick="Button1_Click" />
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 230px"></td>
            </tr>
            <tr>
                <td style="width: 132px; height: 22px;"></td>
                <td style="width: 509px; height: 22px;">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td style="height: 22px"></td>
            </tr>
        </table>
    </div>
   
</asp:Content>
