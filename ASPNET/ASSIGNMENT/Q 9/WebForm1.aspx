<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q_9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 11px;
        }
        .auto-style2 {
            width: 18px;
        }
        .auto-style3 {
            width: 23px;
        }
        .auto-style5 {
            width: 126px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
        .auto-style7 {
            height: 466px;
        }
        .auto-style8 {
            width: 56px;
            height: 22px;
        }
        .auto-style9 {
            height: 22px;
        }
        .auto-style10 {
            width: 56px;
            height: 230px;
        }
        .auto-style11 {
            height: 230px;
        }
        .auto-style12 {
            width: 56px;
            height: 43px;
        }
        .auto-style13 {
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
      
         <div class="auto-style7">
        <table style="width: 100%; height: 289px;">
            <tr>
                <td class="auto-style12"></td>
                <td style="text-align:center; text-decoration: underline;" class="auto-style13"><strong>STUDENT DETAILS FORM</strong></td>
                <td class="auto-style13"></td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td style="vertical-align:top" class="auto-style11">
                    <table class="auto-style15">
                        <tr>
                            <td style="width: 126px">FirstName</td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox1" runat="server" Width="264px" ></asp:TextBox>
                            </td>
                            <td class="auto-style8">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="TextBox1" runat="server" ErrorMessage="Name can't be blank"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 126px">LastName</td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox2" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style8">&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Gender</td>
                            <td class="auto-style14">
                                <asp:DropDownList ID="DropDownList1" runat="server">
                                    <asp:ListItem>Male</asp:ListItem>
                                    <asp:ListItem>Female</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style8">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="DropDownList1" runat="server" ErrorMessage="Can't left Blank"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Age</td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox8" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style8">
                                <asp:RangeValidator ID="RangeValidator1" ControlToValidate="TextBox8" MaximumValue="40" MinimumValue="18" runat="server" ErrorMessage="Age must be between 18 and 40"></asp:RangeValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style16">Email</td>
                            <td class="auto-style17">
                                <asp:TextBox ID="TextBox3" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style21">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ControlToValidate="TextBox3" runat="server" ErrorMessage="Enter Valid email id" ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Address</td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox4" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style8">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style19">Phone Number</td>
                            <td class="auto-style1">
                                <asp:TextBox ID="TextBox5" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style22">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="TextBox5" runat="server" ErrorMessage="Enter Valid Phone Number" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style2">Password</td>
                            <td class="auto-style3">
                                <asp:TextBox ID="TextBox6" TextMode="Password" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style23">
                                <asp:CompareValidator ID="CompareValidator1" ControlToCompare="TextBox7" ControlToValidate="TextBox6" runat="server" ErrorMessage="password and confirm password must be same"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 126px">Confirm Password</td>
                            <td class="auto-style14">
                                <asp:TextBox ID="TextBox7" TextMode="Password" runat="server" Width="264px"></asp:TextBox>
                            </td>
                            <td class="auto-style8">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style5"></td>
                            <td class="auto-style6">
                                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Button" Width="130px" />
                            </td>
                            <td class="auto-style6"></td>
                        </tr>
                    </table>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <br />
                </td>
                <td class="auto-style9">
                    <asp:Button ID="Button2" runat="server" CommandName="firstbutton" OnCommand="Button2_Command" Text="FirstButton" Width="133px" CausesValidation="False" />
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Button ID="Button3" runat="server" Text="SecondButton" Width="134px" CommandName="secondbutton" Oncommand="Button2_Command" CausesValidation="False" />
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9">
                    <asp:Button ID="Button4" runat="server" Text="ThirdButton" Width="135px" CommandName="thirdbutton" OnCommand="Button2_Command" CausesValidation="False" />
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style9"></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
