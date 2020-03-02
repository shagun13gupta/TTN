<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Q8.WebForm1" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContentPlaceHolder" runat="server">

       <div style="height: 171px">
           <table style="width:100%; height: 162px;">
               <tr>
                   <td style="width: 140px; height: 40px"></td>
                   <td style="width: 494px; height: 40px; text-align:center">LOGIN FORM</td>
                   <td style="height: 40px"></td>
               </tr>
               <tr>
                   <td style="width: 140px">&nbsp;</td>
                   <td style="width: 494px">
                       <table style="width:100%;">
                           <tr>
                               <td style="width: 131px">UserName</td>
                               <td style="width: 222px">
                                   <asp:TextBox ID="TextBox3" runat="server" Width="215px"></asp:TextBox>
                               </td>
                               <td>&nbsp;</td>
                           </tr>
                           <tr>
                               <td style="width: 131px">Password</td>
                               <td style="width: 222px">                                 
                                  <asp:TextBox ID="TextBox4" TextMode="Password" runat="server" Width="215px"></asp:TextBox>
                               </td>
                               <td>&nbsp;</td>
                           </tr>
                           <tr>
                               <td style="width: 131px">&nbsp;</td>
                               <td style="width: 222px">&nbsp;</td>
                               <td>
                                   <asp:Button ID="Button1" runat="server" Text="LOGIN" Width="89px" OnClick="Button1_Click" />
                               </td>
                           </tr>
                       </table>
                   </td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td style="width: 140px; height: 24px;"></td>
                   <td style="width: 494px; height: 24px;">
                       <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                   </td>
                   <td style="height: 24px"></td>
               </tr>
           </table>
       </div>

       </asp:Content>
