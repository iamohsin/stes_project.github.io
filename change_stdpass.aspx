<%@ Page Title="" Language="C#" MasterPageFile="~/student_master.Master" AutoEventWireup="true" CodeBehind="change_stdpass.aspx.cs" Inherits="mas.change_stdpass" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style2">
        <tr>
            <td class="w3-right-align" style="width: 475px">
                <asp:Label ID="Label2" runat="server" Text="Enter Current Password"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Check" />
                <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="w3-right-align" style="width: 475px">
                <asp:Label ID="Label3" runat="server" Text="Enter New Password" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;<asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save" Visible="False" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 475px">&nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Visible="False"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
