<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="teacher login.aspx.cs" Inherits="mas.teacher_login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p class="w3-center">
        <!DOCTYPE html>
<html>
<head>
<style>
.center {
  margin: auto;
  width: 60%;
  border: 3px solid #33A8FF ;
  
  padding: 10px;
}
    .auto-style7 {
        width: 220px;
        height: 42px;
    }
    .auto-style9 {
        width: 220px;
        text-align: right;
    }
    .auto-style10 {
        text-align: right;
        width: 92px;
        height: 42px;
    }
    .auto-style11 {
        width: 92px;
    }
    .auto-style12 {
        height: 42px;
        width: 46px;
    }
    .auto-style13 {
        margin-top: 17;
    }
    .auto-style14 {
        text-align: right;
        width: 92px;
        height: 26px;
    }
    .auto-style15 {
        width: 220px;
        height: 26px;
    }
    .auto-style16 {
        height: 26px;
        width: 46px;
    }
    .auto-style17 {
        width: 46px;
    }
</style>
</head>
<body>
    

    <strong>
    <asp:Label ID="Label6" runat="server" style="font-size: xx-large; color: #3399FF; text-decoration: underline; background-color: #FFFFFF" Text="Teacher Panel Login"></asp:Label>
    </strong>
    

<div class="center">
  

    <table align="center">
        <tr>
            <td class="auto-style10">
                <asp:Label ID="Label2" runat="server" Text="Username"></asp:Label>
            </td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1" runat="server" Width="214px"></asp:TextBox>
            </td>
            <td class="auto-style12"></td>
        </tr>
        <tr>
            <td class="auto-style14">Password</td>
            <td class="auto-style15">
                <asp:TextBox ID="TextBox2" runat="server" Width="214px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style16"></td>
        </tr>
        <tr>
            <td class="auto-style11">
                <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:Button ID="Button1" runat="server" CssClass="auto-style13" Text="Sign in" Width="77px" OnClick="Button1_Click" />
            </td>
            <td class="auto-style17">&nbsp;</td>
        </tr>
    </table>
  

</div>

</body>
</html>
</p>
</asp:Content>
